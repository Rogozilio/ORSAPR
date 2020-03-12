using ORSAPR.model.Exceptions;

namespace ORSAPR.model
{
    /// <summary>
    /// Класс для проверки ввода корректных значений полей
    /// </summary>
    class FormValidator
    {   
        /// <summary>
        /// Проверка полей на корректность ввода
        /// </summary>
        /// <param name="casket">Объект шкатулки</param>
        public void CheckWritedValues(Casket casket)
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
                throw new ValueOutOfRangeException(nameValue,min,max);
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
