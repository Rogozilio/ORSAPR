using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolidWorks.Interop.sldworks;

namespace ORSAPR.model
{
    /// <summary>
    /// Класс для построения модели в SolidWorks 2020
    /// </summary>
    class Draw
    {
        SldWorks solidWork;

        IModelDoc2 model;

        private const string TopAxisName = "Сверху";

        private const string NameView = "Изометрия";

        private const string SelectionAxisType = "PLANE"; 

        private const int MilliBetweenBoxAndCap = 5;
        /// <summary>
        /// Строит модель в SolidWorks 2020
        /// </summary>
        /// <param name="casket">объект шкатулки</param>
        public void BuilModel(Casket casket)
        {
            object SW = ExistSolidWork();
            LaunchSolidWork(SW);
            CreateSWFile();
            BuildCasket(casket);
        }
        /// <summary>
        /// Поиск SolidWorks 2020 на компьютере
        /// </summary>
        private object ExistSolidWork()
        {
            try
            {
                Guid myGuid = new Guid("d134b411-3689-497d-b2d7-a27cb1066648");
                object processSW = System.Activator.CreateInstance(System.Type.GetTypeFromCLSID(myGuid));
                return processSW;
            }
            catch
            {
                throw new Exception("GUID SolidWork 2020 не найден");
            }
        }
        /// <summary>
        /// Запускает SolidWorks 2020
        /// </summary>
        private void LaunchSolidWork(object processSW)
        {
            solidWork = (SldWorks)processSW;
            solidWork.Visible = true;
        }
        /// <summary>
        /// Создает файл в SolidWorks 2020
        /// </summary>
        private void CreateSWFile()
        {
            solidWork.NewPart();
            model = solidWork.IActiveDoc2;
        }
        /// <summary>
        /// Строит шкатулку в SolidWorks 2020
        /// </summary>
        /// <param name="casket">объект шкатулки</param>
        private void BuildCasket(Casket casket)
        {
            BuildBox(casket.Box);
            BuildCap(casket.Cap, casket.Box.InnerWidth, casket.Box.InnerLength);
            IsometricView();
        }
        /// <summary>
        /// Строит коробку шкатулки в SolidWorks 2020
        /// </summary>
        /// <param name="box">объект коробки</param>
        private void BuildBox(Box box)
        {
            SelectLayer();
            SelectSketch();
            DrawRectangle(box.Width, box.Length);
            ExtrudeFigure(box.Height);
            SelectLayerByRay(box.Height);
            SelectSketch();
            DrawRectangle(box.InnerWidth, box.InnerLength);
            CutFigure(box.InnerHeight, false);
            RemoveAllocating();
        }
        /// <summary>
        /// Строит крышку шкатулки в SolidWorks 2020
        /// </summary>
        /// <param name="cap">объект крышки</param>
        /// <param name="boxInnerWidth"></param>
        /// <param name="boxInnerLength"></param>
        private void BuildCap(Cap cap, int boxInnerWidth, int boxInnerLength)
        {
            SelectLayer();
            SelectSketch();
            DrawRectangle(cap.Width + MilliBetweenBoxAndCap * 2, cap.Length,
                cap.Width + MilliBetweenBoxAndCap);
            ExtrudeFigure(cap.Height);
            SelectLayer();
            SelectSketch();
            DrawRectangle((cap.Width+ MilliBetweenBoxAndCap)*2 - boxInnerWidth,
                boxInnerLength, cap.Width + MilliBetweenBoxAndCap);
            ExtrudeFigure(cap.Height + cap.ClosingHeight);
            RemoveAllocating();
        }
        /// <summary>
        /// Выбор плоскости
        /// </summary>
        private void SelectLayer()
        {
            model.Extension.SelectByID2(TopAxisName, SelectionAxisType, 0, 0, 0, false, 0, null, 0);
        }
        /// <summary>
        /// Выбирает плоскость, которая пересекает луч
        /// </summary>
        /// <param name="height">Высота луча</param>
        private void SelectLayerByRay(double height)
        {
            model.Extension.SelectByRay(0, height.ToMilli(), 0,
                1, height.ToMilli(), 1, 1, 2, false, 0, 0);
        }
        /// <summary>
        /// Перейти, выйти из режима эскиза
        /// </summary>
        private void SelectSketch()
        {
            model.SketchManager.InsertSketch(true);
        }
        /// <summary>
        /// Убрать все выделения
        /// </summary>
        private void RemoveAllocating()
        {
            model.ClearSelection2(true);
        }
        /// <summary>
        /// Рисует прямоугольник от центра кординат
        /// </summary>
        private void DrawRectangle(double x, double y, double centerX = 0)
        {
            model.SketchManager.CreateCenterRectangle(centerX.ToMilli(), 0, 0, 
                x.ToMilli()/2, y.ToMilli()/2, 0);
        }
        /// <summary>
        /// Вытягивание эскиза
        /// </summary>
        /// <param name="height">Высота вытягивания</param>
        private void ExtrudeFigure(double height)
        {
            model.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, height.ToMilli(), 0.01, false, false, false, false, 
                1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);
        }
        /// <summary>
        /// Вырезание по эскизу
        /// </summary>
        /// <param name="height">Высота выреза</param>
        /// <param name="isUp">Направление выреза</param>
        private void CutFigure(double height, bool isUp = true)
        {
            model.FeatureManager.FeatureCut4(true, false, isUp, 0, 0, height.ToMilli(), 0.01, false, false, false, false, 
                1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false, false);
        }
        /// <summary>
        /// Переключение камеры на вид изометрии
        /// </summary>
        private void IsometricView()
        {
            model.ShowNamedView2(NameView, -1);
            model.ViewZoomtofit2();
        }
    }
}
