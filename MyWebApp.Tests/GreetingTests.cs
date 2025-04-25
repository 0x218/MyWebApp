
using Xunit;

namespace MyWebApp.Tests
{
    public class GreetingTests
    {
        [Theory]
        [InlineData("Alice", "Hello, Alice!")]
        [InlineData("Bob", "Hello, Bob!")]
        public void Greet_ReturnsExpectedMessage(string name, string expected)
        {
            var result = GreetingService.Greet(name);
            Assert.Equal(expected, result);
        }
    }
}
