using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORSAPR.model
{
    /// <summary>
    /// Класс описывает коробку шкатулки
    /// </summary>
    class Box
    {
        public int Width { get; set; }

        public int Length { get; set; }

        public int Height { get; set; }

        public int InnerWidth { get; set; }

        public int InnerLength { get; set; }

        public int InnerHeight { get; set; }
    }
}
