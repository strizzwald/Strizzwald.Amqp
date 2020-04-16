using System;
using NUnit.Framework;

namespace Amqp.Types.Tests
{
    [TestFixture]
    public class AmqpUuidTests
    {
        [Test]
        public void AmqpUuid_ReturnsGuid()
        {
            var encodedGuid = new byte[]
            {
                0xdf, 0xb0, 0xe, 0x67,
                0xef, 0x79, 0x8b, 0x41,
                0xbf, 0xbc, 0xa0, 0xaa,
                0x07, 0x42, 0x5e, 0xd1
            };
            
            var amqpUuid = new AmqpUuid(encodedGuid);
            
            Assert.AreEqual(Guid.Parse("670eb0df-79ef-418b-bfbc-a0aa07425ed1"), amqpUuid.ToGuid());
        }

        [Test]
        public void AmqpUuid_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new AmqpUuid(new byte[] {0x00}));
        }
    }
}