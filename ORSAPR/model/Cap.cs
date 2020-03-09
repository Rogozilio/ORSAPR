using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORSAPR.model
{
    /// <summary>
    /// Класс описывает крышку шкатулки
    /// </summary>
    class Cap
    {
        public int Width { get; set; }

        public int Length { get; set; }

        public int Height { get; set; }
        /// <summary>
        /// Высота закрывающего механизма крышки
        /// </summary>
        public const int ClosingHeight = 10;
    }
}
