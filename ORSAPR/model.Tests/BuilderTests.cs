using NUnit.Framework;
using ORSAPR.model.Interfaces;
using NSubstitute;

namespace ORSAPR.model.Tests
{
    /// <summary>
    /// Модульные тесты для класса Builder
    /// </summary>
    class BuilderTests
    {
        /// <summary>
        /// API SolidWork
        /// </summary>
        private ISolidWorkCommander _commander;
        /// <summary>
        /// Построитель шкатулки
        /// </summary>
        private Builder _builder;
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
            _builder = new Builder();
            _casket = new Casket(true);
            
        }
        /// <summary>
        /// Проверка на существования SolidWork 20202 на PC
        /// </summary>
        [Test]
        public void SolidWorkTest_ExistSolidWork()
        {
            _commander = Substitute.For<ISolidWorkCommander>();
            _commander.IsConnectedToApp.Returns(true);
            Assert.DoesNotThrow(() => _builder.BuilModel(_casket, _commander));
        }
    }
}
