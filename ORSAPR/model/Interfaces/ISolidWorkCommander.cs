/// <summary>
/// API Команды к программе SOLIDWORKS
/// </summary>
namespace ORSAPR.model.Interfaces
{
    /// <summary>
    /// API Команды к программе SOLIDWORKS
    /// </summary>
    public interface ISolidWorkCommander
    {
        /// <summary>
        ///     Есть ли подключение
        /// </summary>
        bool IsConnectedToApp { get; }

        /// <summary>
        /// Запускает SolidWorks 2020
        /// </summary>
        void LaunchSolidWork(object processSW);

        /// <summary>
        /// Создает файл в SolidWorks 2020
        /// </summary>
        void CreateSWFile();

        /// <summary>
        /// Выбор плоскости
        /// </summary>
        void SelectLayer();

        /// <summary>
        /// Выбирает плоскость, которая пересекает луч
        /// </summary>
        /// <param name="height">Высота луча</param>
        void SelectLayerByRay(double height);

        /// <summary>
        /// Перейти, выйти из режима эскиза
        /// </summary>
        void SelectSketch();

        /// <summary>
        /// Убрать все выделения
        /// </summary>
        void RemoveAllocating();

        /// <summary>
        /// Рисует прямоугольник от центра кординат
        /// </summary>
        void DrawRectangle(double x, double y, double centerX = 0);

        /// <summary>
        /// Вытягивание эскиза
        /// </summary>
        /// <param name="height">Высота вытягивания</param>
        void ExtrudeFigure(double height);

        /// <summary>
        /// Вырезание по эскизу
        /// </summary>
        /// <param name="height">Высота выреза</param>
        /// <param name="isUp">Направление выреза</param>
        void CutFigure(double height, bool isUp = true);

        /// <summary>
        /// Переключение камеры на вид изометрии
        /// </summary>
        void IsometricView();
    }
}
