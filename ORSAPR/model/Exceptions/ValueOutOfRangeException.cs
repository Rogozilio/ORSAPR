using System;

namespace ORSAPR.model.Exceptions
{
    public class ValueOutOfRangeException : Exception
    {
        public ValueOutOfRangeException(string nameValue, int min, int max)
            : base(nameValue+" находится вне диапазона допустимых значений "+min+" - "+max)
        {
        }
    }
}
