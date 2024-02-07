using GetGreeting;
using Moq;
namespace GetGreetingTests
{
    public class GreetingProviderTests
    {
        private GreetingProvider _greetingProvider;
        private Mock<ITimeProvider> _timeProviderMock;

        [SetUp]
        public void Setup()
        {
            _timeProviderMock = new Mock<ITimeProvider>();
            _greetingProvider = new GreetingProvider(_timeProviderMock.Object);
        }

        [Test]
        [TestCase(9)] //using EvP method
        [TestCase(5)] //using BVA method
        [TestCase(11)]
        public void GreetingProvider_InputCorrectData_GoodMorningScenario(int hour)
        {
            _timeProviderMock.Setup(x => x.GetCurrentTime()).Returns(new DateTime(2000,2,2,hour,59,9));
            var result = _greetingProvider.GetGreeting();

            Assert.That(result, Is.EqualTo("Good morning!"));
        }
        [Test]
        [TestCase(16)] //using EvP method
        [TestCase(12)] //using BVA method
        [TestCase(17)]
        public void GreetingProvider_InputCorrectData_GoodAfternoon(int hour)
        {
            _timeProviderMock.Setup(x => x.GetCurrentTime()).Returns(new DateTime(2000, 2, 2, hour, 59, 9));
            var result = _greetingProvider.GetGreeting();

            Assert.That(result, Is.EqualTo("Good afternoon!"));
        }
        [Test]
        [TestCase(19)] //using EvP method
        [TestCase(18)] //using BVA method
        [TestCase(21)]
        public void GreetingProvider_InputCorrectData_GoodEveningScenario(int hour)
        {
            _timeProviderMock.Setup(x => x.GetCurrentTime()).Returns(new DateTime(2000, 2, 2, hour, 59, 9));
            var result = _greetingProvider.GetGreeting();

            Assert.That(result, Is.EqualTo("Good evening!"));
        }
        [Test]
        [TestCase(1)] //using EvP method
        [TestCase(4)] //using BVA method
        [TestCase(22)]
        public void GreetingProvider_InputCorrectData_GoodNightScenario(int hour)
        {
            _timeProviderMock.Setup(x => x.GetCurrentTime()).Returns(new DateTime(2000, 2, 2, hour, 59, 9));
            var result = _greetingProvider.GetGreeting();

            Assert.That(result, Is.EqualTo("Good night!"));
        }
    }
}