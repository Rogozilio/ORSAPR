namespace ORSAPR.model
{
    /// <summary>
    /// Класс описывает крышку шкатулки
    /// </summary>
    class Cap
    {
        public int Width { get; set;}

        public int Length { get; set;}

        public int Height { get; set;}
        /// <summary>
        /// Высота закрывающего механизма крышки
        /// </summary>
        public int ClosingHeight{get => 10;}
    }
}
