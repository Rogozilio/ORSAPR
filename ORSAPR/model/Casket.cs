namespace ORSAPR.model
{
    /// <summary>
    /// Класс описывает шкатулки
    /// </summary>
    class Casket
    {
        public Box Box { get; set; }

        public Cap Cap { get; set; }

        public Casket()
        {
            Box = new Box
            {
                Width = 200,
                Length = 200,
                Height = 150,
                InnerWidth = 190,
                InnerLength = 190,
                InnerHeight = 140
            };
            Cap = new Cap
            {
                Width = 210,
                Length = 210,
                Height = 15,
            };
        }
    }
}
