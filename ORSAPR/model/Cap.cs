namespace ORSAPR.model
{
    /// <summary>
    /// Класс описывает крышку шкатулки
    /// </summary>
    class Cap
    {
        private SizeRange _rangeCapWidth = new SizeRange { Max = 230 };

        private SizeRange _rangeCapLength = new SizeRange { Max = 230 };

        public int Width { get; set;}

        public int Length { get; set;}

        public int Height { get; set;}
        /// <summary>
        /// Высота закрывающего механизма крышки
        /// </summary>
        public int ClosingHeight{get => 10;}

        public SizeRange RangeCapWidth
        {
            get => _rangeCapWidth;
            set => _rangeCapWidth.Min = value.Min;
        }
        public SizeRange RangeCapLength
        {
            get => _rangeCapLength;
            set => _rangeCapLength.Min = value.Min;
        }
        public SizeRange RangeCapHeight
        {
            get => new SizeRange { Min = 10, Max = 30 };
        }
    }
}
