using NUnit.Framework;

namespace Amqp.Types.Tests
{
    [TestFixture]
    public class AmqpCharTests
    {
        [Test]
        public void ToChar_ReturnsChar()
        {
            var c = new AmqpChar(0x00);
            
            Assert.AreEqual('0', c.ToChar());
        }
    }
}