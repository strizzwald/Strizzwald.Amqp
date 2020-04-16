using System;
using NUnit.Framework;

namespace Amqp.Types.Tests
{
    [TestFixture]
    public class AmqpUIntTests
    {
        [Test]
        public void ToUInt_ReturnsUInt()
        {
            var i = new AmqpUInt(new byte[] {0x00, 0x00, 0x00, 0x01});

            Assert.AreEqual(1, i.ToUInt());
        }

        [Test]
        public void AmqpUInt_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                new AmqpUInt(new byte[] {0x01, 0x02, 0x03, 0x04, 0x05}));
        }
    }
}