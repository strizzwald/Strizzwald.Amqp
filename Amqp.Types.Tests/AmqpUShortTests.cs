using System;
using NUnit.Framework;

namespace Amqp.Types.Tests
{
    [TestFixture]
    public class AmqpUShortTests
    {
        [Test]
        public void ToUShort_ReturnsUShort()
        {
            var u = new AmqpUShort(new byte[] { 0x00, 0x01 });

            Assert.AreEqual(1, u.ToUShort());
        }

        [Test]
        public void AmqpUShort_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException> (() => new AmqpUShort(new byte[] { 0x00, 0x01, 0x02 }));
        }
    }
}