using NUnit.Framework;
using ORSAPR.model;

namespace UnitTests
{
    /// <summary>
    /// Модульные тесты для класса  NumberExtension
    /// </summary>
    [TestFixture]
    class NumberExtensionTests
    {
        /// <summary>
        /// Перевод метров в миллиметры для целых чисел
        /// </summary>
        /// <param name="value">целое число</param>
        [TestCase(1000)]
        [TestCase(2000)]
        [TestCase(30000)]
        [TestCase(400000)]
        public void NumberExtensionValue_ReturnValueInteger(int value)
        {
            Assert.AreEqual(NumberExtensions.ToMilli(value), value / 1000);
        }
        /// <summary>
        /// Перевод метров в миллиметры для не целых чисел
        /// </summary>
        /// <param name="value">не целое число</param>
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(3.346)]
        [TestCase(46.23)]
        public void NumberExtensionValue_ReturnValueDouble(double value)
        {
            Assert.AreEqual(NumberExtensions.ToMilli(value), value / 1000);
        }
    }
}
