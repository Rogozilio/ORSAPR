namespace ORSAPR.model
{
    /// <summary>
    /// Хранит диапазоны значений полей Casket
    /// </summary>
    class Range
    {
        public SizeRange Width { get; } = new SizeRange { Min = 100, Max = 200 };

        public SizeRange Length { get; } = new SizeRange { Min = 100, Max = 200 };

        public SizeRange Height { get; } = new SizeRange { Min = 50, Max = 150 };

        public SizeRange InnerWidth { get; set; } = new SizeRange { Min = 50 };

        public SizeRange InnerLength { get; set; } = new SizeRange { Min = 50 };

        public SizeRange InnerHeight { get; set; } = new SizeRange { Min = 30 };

        public SizeRange CapWidth { get; set; } = new SizeRange { Max = 230 };

        public SizeRange CapLength { get; set; } = new SizeRange { Max = 230 };

        public SizeRange CapHeight { get; } = new SizeRange { Min = 10, Max = 30 };
    }
}
