using System;
using NUnit.Framework;

namespace Amqp.Types.Tests
{
    [TestFixture]
    public class AmqpFloatTests
    {
        [Test]
        public void ToFloat_ReturnsFloat()
        {
            var f = new AmqpFloat(new byte[] { 0x00, 0x00, 0x00, 0x00 });
            
            Assert.AreEqual(0.0f, f.ToFloat());
        }

        [Test]
        public void AmqpFloat_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new AmqpFloat(new byte[] {0x01, 0x00, 0x00, 0x00, 0x00}));
        }
    }
}