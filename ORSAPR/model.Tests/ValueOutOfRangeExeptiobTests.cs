using NUnit.Framework;
using ORSAPR.model.Exceptions;

namespace ORSAPR.model.Tests
{
    /// <summary>
    /// Модульные тесты для класса ValueOutOfRangeExeption
    /// </summary>
    [TestFixture]
    class ValueOutOfRangeExceptionTests
    {
        /// <summary>
        /// Проверка на вывод корректного сообщения исключения ValueOutOfRangeException
        /// </summary>
        /// <param name="nameValue"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        [TestCase("Ширина основания", 10, 50)]
        [TestCase("Длина внутренней части", 100, 500)]
        [TestCase("Высота крышки", 1000, 5000)]
        public void ExceptionMessageTest(string nameValue, int min, int max)
        {
            ValueOutOfRangeException _exception =
                new ValueOutOfRangeException(nameValue, min, max);
            Assert.AreEqual(_exception.Message,
                nameValue + " находится вне диапазона допустимых значений " + min + " - " + max);
        }
    }
}
