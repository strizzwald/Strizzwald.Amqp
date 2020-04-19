using System.Text;
using NUnit.Framework;

namespace Amqp.Types.Tests
{
    [TestFixture]
    public class AmqpStr32UTF8Tests
    {
        [Test]
        public void AmqpStr32UTF8_ReturnsBytes()
        {
            var helloWorld = "Hello world";
            var helloWorldBytes = Encoding.UTF8.GetBytes(helloWorld);
            var amqpStr = new AmqpStr32UTF8(helloWorldBytes);

            Assert.AreEqual(helloWorld, amqpStr.ToString());
        }
    }
}
