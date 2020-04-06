using System;
using NUnit.Framework;

namespace Amqp.Types.Tests
{
    [TestFixture]
    public class AmqpIntTests
    {
        [Test]
        public void ToInt_ReturnsUInt()
        {
            var i = new AmqpInt(new byte[] {0x01, 0x00, 0x00, 0x00});

            Assert.AreEqual(1, i.ToInt());
        }

        [Test]
        public void AmqpInt_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                new AmqpInt(new byte[] {0x01, 0x02, 0x03, 0x04, 0x05}));
        }
    }
}