using System;
using System.Linq;
using NUnit.Framework;

namespace Amqp.Types.Tests
{
    [TestFixture]
    public class AmqpULongTests
    {
        [Test]
        public void ToLong_ReturnsULong()
        {
            var b = new AmqpULong(
                new byte[] {0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00});
                
            Assert.AreEqual(1, b.ToULong());
        }

        [Test]
        public void AmqpULong_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new AmqpULong(new byte[] {0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00}));
        }
    }
}