using HelloCI.Core;
using Xunit;

namespace HelloCI.Tests.CoreTests
{
    public class MessageTests
    {
        [Fact]
        public void Should_Return_FullMessage()
        {
            Message message = new Message() { Title = "Hello", Body = "CI simple demo"};

            string fullMessage = message.GetFullMessage();

            Assert.True(!string.IsNullOrWhiteSpace(fullMessage));

        }
    }
}
