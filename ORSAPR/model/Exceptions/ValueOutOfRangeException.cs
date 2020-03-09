using System;

namespace ORSAPR.model.Exceptions
{
    public class ValueOutOfRangeException : Exception
    {
        /// <summary>
        /// Если зачение находится вне диапазона min - max
        /// </summary>
        /// <param name="nameValue">Название поля</param>
        /// <param name="min">Минимальное значение поля</param>
        /// <param name="max">Максимальное значение поля</param>
        public ValueOutOfRangeException(string nameValue, int min, int max)
            : base(nameValue+" находится вне диапазона допустимых значений "+min+" - "+max)
        {
        }
    }
}
