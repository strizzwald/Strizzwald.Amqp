using System;
using NUnit.Framework;

namespace Amqp.Types.Tests
{

    [TestFixture]
    public class AmqpDateTimeTests
    {
        [Test]
        public void ToDateTime_ReturnsDateTime()
        {
            var b = DateTimeOffset.UnixEpoch.AddDays(1);
            var bytes = new Span<byte>(new byte[sizeof(long)]);

            if (!BitConverter.TryWriteBytes(bytes, b.ToUnixTimeMilliseconds()))
            {
               Assert.Fail($"Invalid cast {nameof(b)}");
            }
            
            var t = new AmqpTimestamp(bytes.ToArray());
            Assert.AreEqual(DateTimeOffset.UnixEpoch.AddDays(1), t.ToDatetimeOffset());
        }

        [Test]
        public void AmqpTimeStamp_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new AmqpTimestamp(new byte[0]));
        }
    }
}