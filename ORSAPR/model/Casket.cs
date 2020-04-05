using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ORSAPR.model.Exceptions;

namespace ORSAPR.model
{
    /// <summary>
    /// Класс описывает шкатулки
    /// </summary>
    class Casket
    {
        public Box Box { get; } = new Box();

        public Cap Cap { get; } = new Cap();

        public Range Range = new Range();

        public Casket()
        {
            Box.Width = 200;
            Box.Length = 200;
            Box.Height = 150;
            Box.InnerWidth = 190;
            Box.InnerLength = 190;
            Box.InnerHeight = 140;
            Cap.Width = 210;
            Cap.Length = 210;
            Cap.Height = 15;
            CheckWritedValues();
        }
        public Casket(List<TextBox> textBox)
        {
            try
            {
                foreach(var value in textBox)
                {
                    switch (value.TabIndex)
                    {
                        case 1:
                            Box.Width = int.Parse(value.Text);
                            break;
                        case 2:
                            Box.Length = int.Parse(value.Text);
                            break;
                        case 3:
                            Box.Height = int.Parse(value.Text);
                            break;
                        case 4:
                            Box.InnerWidth = int.Parse(value.Text);
                            break;
                        case 5:
                            Box.InnerLength = int.Parse(value.Text);
                            break;
                        case 6:
                            Box.InnerHeight = int.Parse(value.Text);
                            break;
                        case 7:
                            Cap.Width = int.Parse(value.Text);
                            break;
                        case 8:
                            Cap.Length = int.Parse(value.Text);
                            break;
                        case 9:
                            Cap.Height = int.Parse(value.Text);
                            break;
                    }
                }
            }
            catch
            {
                throw new Exception("Заполните все поля");
            }
            CheckWritedValues();
        }
        /// <summary>
        /// Проверка полей на корректность ввода
        /// </summary>
        /// <param name="casket">Объект шкатулки</param>
        private void CheckWritedValues()
        {
            GetDependValues();
            CheckRangeValue(Box.Width, Range.Width.Min,
                Range.Width.Max, "Ширина основания");
            CheckRangeValue(Box.Length, Range.Length.Min,
                Range.Length.Max, "Длина основания");
            CheckRangeValue(Box.Height, Range.Height.Min,
                Range.Height.Max, "Высота основания");

            CheckRangeValue(Box.InnerWidth, Range.InnerWidth.Min,
                Range.InnerWidth.Max, "Ширина внутренней части");
            CheckRangeValue(Box.InnerLength, Range.InnerLength.Min,
                Range.InnerLength.Max, "Длина внутренней части");
            CheckRangeValue(Box.InnerHeight, Range.InnerHeight.Min,
                Range.InnerHeight.Max, "Высота внутренней части");

            CheckRangeValue(Cap.Width, Range.CapWidth.Min,
                Range.CapWidth.Max, "Ширина крышки");
            CheckRangeValue(Cap.Length, Range.CapLength.Min,
                Range.CapLength.Max, "Длина крышки");
            CheckRangeValue(Cap.Height, Range.CapHeight.Min,
                Range.CapHeight.Max, "Высота крышки");
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
            Range.InnerWidth.Max = Box.Width - 5;
            Range.InnerLength.Max = Box.Length - 5;
            Range.InnerHeight.Max = Box.Height - 5;
            Range.CapWidth.Min = Box.InnerWidth + 1;
            Range.CapLength.Min = Box.InnerLength + 1;
        }
    }
}
