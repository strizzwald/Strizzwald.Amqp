using System;
using System.Linq;
using NUnit.Framework;

namespace Amqp.Types.Tests
{
    [TestFixture]
    public class AmqpVBin32Tests
    {
        [Test]
        public void AmqpVBin32_ReturnsBytes()
        {
            byte[] bytes = new byte[] { 0x00, 0x00, 0x00, 0x01 };

            var amqpVBin8 = new AmqpVBin32(bytes);

            if (BitConverter.IsLittleEndian)
            {
                Assert.AreEqual(bytes.Reverse().ToArray(), amqpVBin8.ToBytes());
            }
            else
            {
                Assert.AreEqual(bytes, amqpVBin8.ToBytes());
            }
        }
    }
}
