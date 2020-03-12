namespace ORSAPR.model
{
    /// <summary>
    /// Класс описывает коробку шкатулки
    /// </summary>
    class Box
    {
        private SizeRange _rangeInnerWidth = new SizeRange {Min = 50};

        private SizeRange _rangeInnerLength = new SizeRange {Min = 50};

        private SizeRange _rangeInnerHeight = new SizeRange {Min = 30};

        public int Width { get; set; }

        public int Length { get; set; }

        public int Height { get; set; }

        public int InnerWidth { get; set; }

        public int InnerLength { get; set; }

        public int InnerHeight { get; set; }

        public SizeRange RangeWidth
        {
            get => new SizeRange { Min = 100, Max = 200 };
        }
        public SizeRange RangeLength
        {
            get => new SizeRange { Min = 100, Max = 200 };
        }
        public SizeRange RangeHeight
        {
            get => new SizeRange { Min = 50, Max = 150 };
        }
        public SizeRange RangeInnerWidth
        {
            get => _rangeInnerWidth;
            set => _rangeInnerWidth.Max = value.Max;
        }
        public SizeRange RangeInnerLength
        {
            get => _rangeInnerLength;
            set => _rangeInnerLength.Max = value.Max;
        }
        public SizeRange RangeInnerHeight
        {
            get => _rangeInnerHeight;
            set => _rangeInnerHeight.Max = value.Max;
        }
    }
}
