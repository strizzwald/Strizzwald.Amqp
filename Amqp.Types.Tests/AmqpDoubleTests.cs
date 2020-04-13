using System;
using NUnit.Framework;

namespace Amqp.Types.Tests
{
    [TestFixture]
    public class AmqpDoubleTests
    {
        [Test]
        public void ToDouble_ReturnsDouble()
        {
            var d = new AmqpDouble(new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            
            Assert.AreEqual(0.0d, d.ToDouble());
        }

        [Test]
        public void AmqpDouble_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new AmqpDouble(new byte[] {0x00}));
        }
    }
}