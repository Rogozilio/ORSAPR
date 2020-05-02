using System.Collections;
using NUnit.Framework;
using ORSAPR.model.Exceptions;

namespace ORSAPR.model.Tests
{
    /// <summary>
    /// Модульные тесты для класса Casket
    /// </summary>
    class CasketTests
    {
        /// <summary>
        /// Шкатулка с значениями по умолчанию
        /// </summary>
        private Casket _casketDefault;
        /// <summary>
        /// Шкатулка
        /// </summary>
        private Casket _casket;
        /// <summary>
        /// Инициализировать перед каждым тестом
        /// </summary>
        [SetUp]
        public void InitializeForTest()
        {
            _casketDefault = new Casket(true);
            _casket = new Casket();
            _casket.BoxWidth.Value = 170;
            _casket.BoxLength.Value = 170;
            _casket.BoxHeight.Value = 150;
            _casket.BoxInnerWidth.Value = 140;
            _casket.BoxInnerLength.Value = 140;
            _casket.BoxInnerHeight.Value = 100;
            _casket.CapWidth.Value = 200;
            _casket.CapLength.Value = 200;
            _casket.CapHeight.Value = 20;
            _casket.CheckWritedValues();
        }
        /// <summary>
        /// Проверка значений шкатулки по умолчанию
        /// </summary>
        [Test]
        public void ConstructorTest_DefaultValue()
        {
            Assert.AreEqual(_casketDefault.BoxWidth.Value, 200);
            Assert.AreEqual(_casketDefault.BoxLength.Value, 200);
            Assert.AreEqual(_casketDefault.BoxHeight.Value, 150);
            Assert.AreEqual(_casketDefault.BoxInnerWidth.Value, 190);
            Assert.AreEqual(_casketDefault.BoxInnerLength.Value, 190);
            Assert.AreEqual(_casketDefault.BoxInnerHeight.Value, 140);
            Assert.AreEqual(_casketDefault.CapWidth.Value, 210);
            Assert.AreEqual(_casketDefault.CapLength.Value, 210);
            Assert.AreEqual(_casketDefault.CapHeight.Value, 15);
            Assert.AreEqual(_casketDefault.ClosingHeight, 10);
        }
        /// <summary>
        /// Проверка зависимых значений шкатулки
        /// </summary>
        [Test]
        public void CasketValueTest_DependValue()
        {
            Assert.AreEqual(_casket.BoxInnerWidth.Max, 165);
            Assert.AreEqual(_casket.BoxInnerLength.Max, 165);
            Assert.AreEqual(_casket.BoxInnerHeight.Max, 145);
            Assert.AreEqual(_casket.CapWidth.Min, 141);
            Assert.AreEqual(_casket.CapLength.Min, 141);
        }
        /// <summary>
        /// Проверка границ диапазонов шкатулки
        /// </summary>
        [Test]
        public void CasketValueTest_ValueEdgeRange()
        {
            Assert.AreEqual(_casket.BoxWidth.Min, 100);
            Assert.AreEqual(_casket.BoxWidth.Max, 200);
            Assert.AreEqual(_casket.BoxLength.Min, 100);
            Assert.AreEqual(_casket.BoxLength.Max, 200);
            Assert.AreEqual(_casket.BoxHeight.Min, 50);
            Assert.AreEqual(_casket.BoxHeight.Max, 150);
            Assert.AreEqual(_casket.BoxInnerWidth.Min, 50);
            Assert.AreEqual(_casket.BoxInnerLength.Min, 50);
            Assert.AreEqual(_casket.BoxInnerHeight.Min, 30);
            Assert.AreEqual(_casket.CapWidth.Max, 230);
            Assert.AreEqual(_casket.CapLength.Max, 230);
            Assert.AreEqual(_casket.CapHeight.Min, 10);
            Assert.AreEqual(_casket.CapHeight.Max, 30);
        }
        /// <summary>
        /// Проверка на выбрасования исключения ValueOutOfRangeException 
        /// </summary>
        /// <param name="casket">Объект шкатулки</param>
        [TestCaseSource(typeof(CasketTestsData), nameof(CasketTestsData.CasketNegative))]
        public void CasketValueTest_RangeExeption(Casket casket)
        {
            Assert.Throws<ValueOutOfRangeException>(()=> casket.CheckWritedValues());
        }
        /// <summary>
        /// Тестовые данные для CasketTests
        /// </summary>
        public static class CasketTestsData
        {
            /// <summary>
            /// Негативные значения Casket
            /// </summary>
            public static IEnumerable CasketNegative
            {
                get
                {
                    yield return new TestCaseData(new Casket
                    {
                        BoxWidth = new RangedValue { Min = 100, Value = 50, Max = 200 },
                        BoxLength = new RangedValue { Min = 100, Value = 150, Max = 200 },
                        BoxHeight = new RangedValue { Min = 50, Value = 140, Max = 150 },
                        BoxInnerWidth = new RangedValue { Min = 50, Value = 100 },
                        BoxInnerLength = new RangedValue { Min = 50, Value = 100 },
                        BoxInnerHeight = new RangedValue { Min = 30, Value = 100 },
                        CapWidth = new RangedValue { Value = 150, Max = 230 },
                        CapLength = new RangedValue { Value = 150, Max = 230 },
                        CapHeight = new RangedValue { Min = 10, Value = 20, Max = 30 }
                    });
                }
            }
        }
    }
}
