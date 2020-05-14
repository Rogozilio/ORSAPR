using System;
using ORSAPR.model.Interfaces;

namespace ORSAPR.model
{
    /// <summary>
    /// Класс для построения модели в SolidWorks 2020
    /// </summary>
    public class Builder
    {
        /// <summary>
        /// API SolidWorka
        /// </summary>
        private ISolidWorkCommander _commander = new SolidWorksCommander();
        /// <summary>
        /// Расстояние между коробкой и крышкой
        /// </summary>
        private const int MilliBetweenBoxAndCap = 5;
        /// <summary>
        /// Строит модель в SolidWorks 2020
        /// </summary>
        /// <param name="casket">объект шкатулки</param>
        public void BuilModel(Casket casket, ISolidWorkCommander commander)
        {
            object SW = ExistSolidWork();
            _commander = commander;
            _commander.LaunchSolidWork(SW);
            _commander.CreateSWFile();
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
                throw new Exception("GUID SolidWorks 2020 не найден");
            }
        }
       
        /// <summary>
        /// Строит шкатулку в SolidWorks 2020
        /// </summary>
        /// <param name="casket">объект шкатулки</param>
        private void BuildCasket(Casket casket)
        {
            BuildBox(casket);
            BuildCap(casket);
            _commander.IsometricView();
        }
        /// <summary>
        /// Строит коробку шкатулки в SolidWorks 2020
        /// </summary>
        /// <param name="box">объект коробки</param>
        private void BuildBox(Casket casket)
        {
            _commander.SelectLayer();
            _commander.SelectSketch();
            _commander.DrawRectangle(casket.BoxWidth.Value, casket.BoxLength.Value);
            _commander.ExtrudeFigure(casket.BoxHeight.Value);
            _commander.SelectLayerByRay(casket.BoxHeight.Value);
            _commander.SelectSketch();
            _commander.DrawRectangle(casket.BoxInnerWidth.Value, casket.BoxInnerLength.Value);
            _commander.CutFigure(casket.BoxInnerHeight.Value, false);
            _commander.RemoveAllocating();
        }
        /// <summary>
        /// Строит крышку шкатулки в SolidWorks 2020
        /// </summary>
        /// <param name="cap">объект крышки</param>
        private void BuildCap(Casket casket)
        {
            double XBaseCap = casket.BoxWidth.Value + 
                MilliBetweenBoxAndCap * 2;
            double XInnertCap = casket.BoxWidth.Value + 
                MilliBetweenBoxAndCap * 2 +
                (casket.CapWidth.Value - casket.BoxInnerWidth.Value);
            double CenterXForCap = casket.BoxWidth.Value / 2 + 
                MilliBetweenBoxAndCap + 
                casket.CapWidth.Value / 2;   
            _commander.SelectLayer();
            _commander.SelectSketch();
            _commander.DrawRectangle(XBaseCap,
                casket.CapLength.Value,
                CenterXForCap);
            _commander.ExtrudeFigure(casket.CapHeight.Value);
            _commander.SelectLayer();
            _commander.SelectSketch();
            _commander.DrawRectangle(XInnertCap,
                casket.BoxInnerLength.Value,
                CenterXForCap);
            _commander.ExtrudeFigure(casket.CapHeight.Value + casket.ClosingHeight);
            _commander.RemoveAllocating();
        }
    }
}
