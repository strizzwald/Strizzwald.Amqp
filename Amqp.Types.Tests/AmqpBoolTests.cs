using System;
using NUnit.Framework;

namespace Amqp.Types.Tests
{
    [TestFixture]
    public class AmqpBoolTests
    {
        private const byte AmqpFalse = 0x00;
        private const byte AmqpTrue = 0x01;
        
        [Test]
        public void ToBool_ReturnsBool_FalseAmqpEncodingArg()
        {
            var b = new AmqpBool(AmqpFalse);
            
            Assert.False(b.ToBool());
        }

        [Test]
        public void ToBool_ReturnsBool_TrueAmqpEncodingArg()
        {
            var b = new AmqpBool(AmqpTrue);
            
            Assert.True(b.ToBool());
        }

        [Test]
        public void AmqpBool_ThrowsException_UnknownEncoding()
        {
            Assert.Throws<InvalidOperationException>(() => new AmqpBool(0x20));
        }
    }
}