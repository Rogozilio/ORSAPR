namespace ORSAPR.model
{
    class ValueCasketDefault
    {
        /// <summary>
        /// Шкатулка с значениями по умолчанию
        /// </summary>
        public Casket casket = new Casket
        {
            Box = new Box
            {
                Width = 200,
                Length = 200,
                Height = 150,
                InnerWidth = 190,
                InnerLength = 190,
                InnerHeight = 140
            },
            Cap = new Cap
            {
                Width = 210,
                Length = 210,
                Height = 15,
            },
        };
    }
}
