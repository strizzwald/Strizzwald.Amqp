using System;
using System.Linq;
using NUnit.Framework;

namespace Amqp.Types.Tests
{
    public class AmqpVBin32Tests
    {
        [Test]
        public void AmqpVBin32_ReturnsBytes()
        {
            byte[] bytes = new byte[] { 0x00, 0x00, 0x00, 0x01 };

            var amqpVBin32 = new AmqpVBin32(bytes);

            if (BitConverter.IsLittleEndian)
            {
                Assert.AreEqual(bytes.Reverse().ToArray(), amqpVBin32.ToBytes());
            }
            else
            {
                Assert.AreEqual(bytes, amqpVBin32.ToBytes());
            }
            
        }

        [Test]
        public void AmqpVBin32_ThrowsException()
        {
            byte[] bytes = Enumerable.Range(1, 2 ^ 32)
                .Select(x => (byte)0x00)
                .ToArray();
        }
    }
}
