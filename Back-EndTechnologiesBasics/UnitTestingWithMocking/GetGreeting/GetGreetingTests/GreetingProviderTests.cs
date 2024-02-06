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
        public void GreetingProviderTests()
        {
            Assert.Pass();
        }
    }
}