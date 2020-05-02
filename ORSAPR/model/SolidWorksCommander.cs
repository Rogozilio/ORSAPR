using SolidWorks.Interop.sldworks;
using ORSAPR.model.Interfaces;

namespace ORSAPR.model
{
    /// <summary>
    /// API Команды к программе SOLIDWORKS
    /// </summary>
    class SolidWorksCommander : ISolidWorkCommander
    {
        /// <summary>
        /// Объект API программы SOLIDWORKS
        /// </summary>
        private SldWorks _solidWork;
        /// <summary>
        /// Объект API текущего проекта в программе SOLIDWORKS
        /// </summary>
        private IModelDoc2 _model;
        /// <summary>
        /// Название верхней оси
        /// </summary>
        private const string _topAxisName = "Сверху";
        /// <summary>
        /// Название вида камеры
        /// </summary>
        private const string _nameView = "Изометрия";
        /// <summary>
        ///     Тип выделения для выбора оси
        /// </summary>
        private const string _selectionAxisType = "PLANE";
        /// <summary>
        /// Есть ли подключение
        /// </summary>
        public bool IsConnectedToApp => _solidWork != null;
        /// <summary>
        /// Запускает SolidWorks 2020
        /// </summary>
        public void LaunchSolidWork(object processSW)
        {
            _solidWork = (SldWorks)processSW;
            _solidWork.Visible = true;
        }
        /// <summary>
        /// Создает файл в SolidWorks 2020
        /// </summary>
        public void CreateSWFile()
        {
            if (!IsConnectedToApp)
            {
                return;
            }
            _solidWork.NewPart();
            _model = _solidWork.IActiveDoc2;
        }
        /// <summary>
        /// Выбор плоскости
        /// </summary>
        public void SelectLayer()
        {
            if (!IsConnectedToApp)
            {
                return;
            }
            _model.Extension.SelectByID2(_topAxisName, _selectionAxisType, 0, 0, 0, false, 0, null, 0);
        }
        /// <summary>
        /// Выбирает плоскость, которая пересекает луч
        /// </summary>
        /// <param name="height">Высота луча</param>
        public void SelectLayerByRay(double height)
        {
            if (!IsConnectedToApp)
            {
                return;
            }
            _model.Extension.SelectByRay(0, height.ToMilli(), 0,
                1, height.ToMilli(), 1, 1, 2, false, 0, 0);
        }
        /// <summary>
        /// Перейти, выйти из режима эскиза
        /// </summary>
        public void SelectSketch()
        {
            if (!IsConnectedToApp)
            {
                return;
            }
            _model.SketchManager.InsertSketch(true);
        }
        /// <summary>
        /// Убрать все выделения
        /// </summary>
        public void RemoveAllocating()
        {
            if (!IsConnectedToApp)
            {
                return;
            }
            _model.ClearSelection2(true);
        }
        /// <summary>
        /// Рисует прямоугольник от центра кординат
        /// </summary>
        public void DrawRectangle(double x, double y, double centerX = 0)
        {
            if (!IsConnectedToApp)
            {
                return;
            }
            _model.SketchManager.CreateCenterRectangle(centerX.ToMilli(), 0, 0,
                x.ToMilli() / 2, y.ToMilli() / 2, 0);
        }
        /// <summary>
        /// Вытягивание эскиза
        /// </summary>
        /// <param name="height">Высота вытягивания</param>
        public void ExtrudeFigure(double height)
        {
            if (!IsConnectedToApp)
            {
                return;
            }
            _model.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, height.ToMilli(), 0.01, false, false, false, false,
                1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);
        }
        /// <summary>
        /// Вырезание по эскизу
        /// </summary>
        /// <param name="height">Высота выреза</param>
        /// <param name="isUp">Направление выреза</param>
        public void CutFigure(double height, bool isUp = true)
        {
            if (!IsConnectedToApp)
            {
                return;
            }
            _model.FeatureManager.FeatureCut4(true, false, isUp, 0, 0, height.ToMilli(), 0.01, false, false, false, false,
                1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false, false);
        }
        /// <summary>
        /// Переключение камеры на вид изометрии
        /// </summary>
        public void IsometricView()
        {
            if (!IsConnectedToApp)
            {
                return;
            }
            _model.ShowNamedView2(_nameView, -1);
            _model.ViewZoomtofit2();
        }
    }
}
