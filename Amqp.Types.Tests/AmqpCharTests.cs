using System;
using NUnit.Framework;

namespace Amqp.Types.Tests
{
    [TestFixture]
    public class AmqpCharTests
    {
        [Test]
        public void ToChar_ReturnsChar()
        {
            var c = new AmqpChar(new byte[] {0x00, 0x00, 0x00, 0x00});
            
            Assert.AreEqual('\u0000', c.ToChar());
        }

        [Test]
        public void ToChar_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new AmqpChar(new byte[] {0x00}));
        }
    }
}