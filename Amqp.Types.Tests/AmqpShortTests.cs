using System;
using NUnit.Framework;

namespace Amqp.Types.Tests
{
    [TestFixture]
    public class AmqpShortTests
    {
        [Test]
        public void ToShort_ReturnsShort()
        {
            var u = new AmqpShort(new byte[] { 0x00, 0x01 });

            Assert.AreEqual(1, u.ToShort());
        }

        [Test]
        public void AmqpShort_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException> (() => new AmqpUShort(new byte[] { 0x00, 0x01, 0x02 }));
        }
    }
}