using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ORSAPR.model.Exceptions;

namespace ORSAPR.model
{
    /// <summary>
    /// Класс описывает шкатулки
    /// </summary>
    public class Casket
    {
        public RangedValue BoxWidth { get; set; } = new RangedValue { Min = 100, Max = 200 };

        public RangedValue BoxLength { get; set; } = new RangedValue { Min = 100, Max = 200 };

        public RangedValue BoxHeight { get; set; } = new RangedValue { Min = 50, Max = 150 };

        public RangedValue BoxInnerWidth { get; set; } = new RangedValue { Min = 50 };

        public RangedValue BoxInnerLength { get; set; } = new RangedValue { Min = 50 };

        public RangedValue BoxInnerHeight { get; set; } = new RangedValue { Min = 30 };

        public RangedValue CapWidth { get; set; } = new RangedValue { Max = 230 };

        public RangedValue CapLength { get; set; } = new RangedValue { Max = 230 };

        public RangedValue CapHeight { get; set; } = new RangedValue { Min = 10, Max = 30 };
        /// <summary>
        /// Высота закрывающего механизма крышки
        /// </summary>
        public int ClosingHeight { get => 10; }

        public Casket(bool isDefault = false)
        {
            if(isDefault)
            {
                BoxWidth.Value = 200;
                BoxLength.Value = 200;
                BoxHeight.Value = 150;
                BoxInnerWidth.Value = 190;
                BoxInnerLength.Value = 190;
                BoxInnerHeight.Value = 140;
                CapWidth.Value = 210;
                CapLength.Value = 210;
                CapHeight.Value = 15;
                CheckWritedValues();
            }
        }
        /// <summary>
        /// Проверка полей на корректность ввода
        /// </summary>
        /// <param name="casket">Объект шкатулки</param>
        public void CheckWritedValues()
        {
            GetDependValues();
            CheckRangeValue(BoxWidth.Value, BoxWidth.Min,
                BoxWidth.Max, "Ширина основания");
            CheckRangeValue(BoxLength.Value, BoxLength.Min,
                BoxLength.Max, "Длина основания");
            CheckRangeValue(BoxHeight.Value, BoxHeight.Min,
                BoxHeight.Max, "Высота основания");

            CheckRangeValue(BoxInnerWidth.Value, BoxInnerWidth.Min,
                BoxInnerWidth.Max, "Ширина внутренней части");
            CheckRangeValue(BoxInnerLength.Value, BoxInnerLength.Min,
                BoxInnerLength.Max, "Длина внутренней части");
            CheckRangeValue(BoxInnerHeight.Value, BoxInnerHeight.Min,
                BoxInnerHeight.Max, "Высота внутренней части");

            CheckRangeValue(CapWidth.Value, CapWidth.Min,
                CapWidth.Max, "Ширина крышки");
            CheckRangeValue(CapLength.Value, CapLength.Min,
                CapLength.Max, "Длина крышки");
            CheckRangeValue(CapHeight.Value,CapHeight.Min,
                CapHeight.Max, "Высота крышки");
        }
        /// <summary>
        /// Проверка value в диапазоне (min-max)
        /// </summary>
        /// <param name="value">Значение поля</param>
        /// <param name="min">Минимальная значение</param>
        /// <param name="max">Максимальное значение</param>
        /// <param name="textException">Текст при нарушении диапазона</param>
        private void CheckRangeValue(int value, int min, int max, string nameValue)
        {
            if (value < min || value > max)
                throw new ValueOutOfRangeException(nameValue, min, max);
        }
        /// <summary>
        /// Получение зависимых значений
        /// </summary>
        /// <param name="casket">Объект шкатулки</param>
        private void GetDependValues()
        {
            BoxInnerWidth.Max = BoxWidth.Value - 5;
            BoxInnerLength.Max = BoxLength.Value - 5;
            BoxInnerHeight.Max = BoxHeight.Value - 5;
            CapWidth.Min = BoxInnerWidth.Value + 1;
            CapLength.Min = BoxInnerLength.Value + 1;
        }
    }
}
