using System;
using NUnit.Framework;

namespace Amqp.Types.Tests
{
    [TestFixture]
    public class AmqpLongTests
    {

        [Test]
        public void AmqpLong_ReturnsLong()
        {
            var b = new AmqpLong(
                new byte[] {0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00});
                
            Assert.AreEqual(1, b.ToLong());
        }
        
        [Test]
        public void AmqpLong_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new AmqpLong(new byte[] {0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00}));
        }

    }
}