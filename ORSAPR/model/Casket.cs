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
            CheckWritedValues(this);
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
            CheckWritedValues(this);
        }
        /// <summary>
        /// Проверка полей на корректность ввода
        /// </summary>
        /// <param name="casket">Объект шкатулки</param>
        private void CheckWritedValues(Casket casket)
        {
            GetDependValues(casket);
            CheckRangeValue(casket.Box.Width, casket.Box.RangeWidth.Min,
                casket.Box.RangeWidth.Max, "Ширина основания");
            CheckRangeValue(casket.Box.Length, casket.Box.RangeLength.Min,
                casket.Box.RangeLength.Max, "Длина основания");
            CheckRangeValue(casket.Box.Height, casket.Box.RangeHeight.Min,
                casket.Box.RangeHeight.Max, "Высота основания");

            CheckRangeValue(casket.Box.InnerWidth, casket.Box.RangeInnerWidth.Min,
                casket.Box.RangeInnerWidth.Max, "Ширина внутренней части");
            CheckRangeValue(casket.Box.InnerLength, casket.Box.RangeInnerLength.Min,
                casket.Box.RangeInnerLength.Max, "Длина внутренней части");
            CheckRangeValue(casket.Box.InnerHeight, casket.Box.RangeInnerHeight.Min,
                casket.Box.RangeInnerHeight.Max, "Высота внутренней части");

            CheckRangeValue(casket.Cap.Width, casket.Cap.RangeCapWidth.Min,
                casket.Cap.RangeCapWidth.Max, "Ширина крышки");
            CheckRangeValue(casket.Cap.Length, casket.Cap.RangeCapLength.Min,
                casket.Cap.RangeCapLength.Max, "Длина крышки");
            CheckRangeValue(casket.Cap.Height, casket.Cap.RangeCapHeight.Min,
                casket.Cap.RangeCapHeight.Max, "Высота крышки");
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
        private void GetDependValues(Casket casket)
        {
            casket.Box.RangeInnerWidth.Max = casket.Box.Width - 5;
            casket.Box.RangeInnerLength.Max = casket.Box.Length - 5;
            casket.Box.RangeInnerHeight.Max = casket.Box.Height - 5;
            casket.Cap.RangeCapWidth.Min = casket.Box.InnerWidth + 1;
            casket.Cap.RangeCapLength.Min = casket.Box.InnerLength + 1;
        }
    }
}
