using ORSAPR.model.Exceptions;
using System;
using ORSAPR.model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORSAPR.model
{
    /// <summary>
    /// Класс для проверки ввода корректных значений полей
    /// </summary>
    class FormValidator
    {
        private SizeRange _rangeWidth = new SizeRange { Min = 100, Max = 200 };

        private SizeRange _rangeLength = new SizeRange { Min = 100, Max = 200 };

        private SizeRange _rangeHeight = new SizeRange { Min = 50, Max = 150 };

        private SizeRange _rangeInnerWidth = new SizeRange { Min = 50, Max = 200 };

        private SizeRange _rangeInnerLength = new SizeRange { Min = 50, Max = 200 };

        private SizeRange _rangeInnerHeight = new SizeRange { Min = 30, Max = 150 };

        private SizeRange _rangeCapWidth = new SizeRange { Min = 100, Max = 230 };

        private SizeRange _rangeCapLength = new SizeRange { Min = 100, Max = 230 };

        private SizeRange _rangeCapHeight = new SizeRange { Min = 10, Max = 30 };
        /// <summary>
        /// Проверка полей на корректность ввода
        /// </summary>
        /// <param name="casket">Объект шкатулки</param>
        public void CheckWritedValues(Casket casket)
        {
            GetDependValues(casket);

            CheckRangeValue(casket.Box.Width, _rangeWidth.Min, _rangeWidth.Max, "Ширина основания");
            CheckRangeValue(casket.Box.Length, _rangeLength.Min, _rangeLength.Max, "Длина основания");
            CheckRangeValue(casket.Box.Height, _rangeHeight.Min, _rangeHeight.Max, "Высота основания");

            CheckRangeValue(casket.Box.InnerWidth, _rangeInnerWidth.Min, _rangeInnerWidth.Max, "Ширина внутренней части");
            CheckRangeValue(casket.Box.InnerLength, _rangeInnerLength.Min, _rangeInnerLength.Max, "Длина внутренней части");
            CheckRangeValue(casket.Box.InnerHeight, _rangeInnerHeight.Min, _rangeInnerHeight.Max, "Высота внутренней части");

            CheckRangeValue(casket.Cap.Width, _rangeCapWidth.Min, _rangeCapWidth.Max, "Ширина крышки");
            CheckRangeValue(casket.Cap.Length, _rangeCapLength.Min, _rangeCapLength.Max, "Длина крышки");
            CheckRangeValue(casket.Cap.Height, _rangeCapHeight.Min, _rangeCapHeight.Max, "Высота крышки");
        }
        /// <summary>
        /// Проверка value в диапазоне (min-max) 
        /// </summary>
        /// <param name="value">Значение поля</param>
        /// <param name="min">Минимальная значение</param>
        /// <param name="max">Максимальное значение</param>
        /// <param name="textException">Текст при нарушении диапазона</param>
        private void CheckRangeValue(int value, int min, int max, string nameException)
        {
            if (value < min || value > max)
                throw new ValueOutOfRangeException(nameException,min,max);
        }
        /// <summary>
        /// Получение зависимых значений
        /// </summary>
        /// <param name="casket">Объект шкатулки</param>
        private void GetDependValues(Casket casket)
        {
            _rangeInnerWidth.Max = casket.Box.Width - 5;
            _rangeInnerLength.Max = casket.Box.Length - 5;
            _rangeInnerHeight.Max = casket.Box.Height - 5;
            _rangeCapWidth.Min = casket.Box.InnerWidth + 1;
            _rangeCapLength.Min = casket.Box.InnerLength + 1;
        }
    }
}
