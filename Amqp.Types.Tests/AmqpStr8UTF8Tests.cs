using System;
using System.Text;
using NUnit.Framework;

namespace Amqp.Types.Tests
{
    [TestFixture]
    public class AmqpStr8UTF8Tests
    {
        [Test]
        public void AmqpStr8UTF8_ReturnsString()
        {
            var helloWorld = "Hello world";
            var helloWorldBytes = Encoding.UTF8.GetBytes(helloWorld);
            var amqpStr = new AmqpStr8UTF8(helloWorldBytes);


            Assert.AreEqual(helloWorld, amqpStr.ToString());
        }

        [Test]
        public void AmqpStr8UTF8_ThrowsException()
        {
            StringBuilder sb = new StringBuilder();

            for (var i = 0; i < (ushort)Math.Pow(2, 8); i++)
            {
                sb.Append(" ");
            }


            var bytes = Encoding.UTF8.GetBytes(sb.ToString());

            Assert.Throws<ArgumentOutOfRangeException>(() => new AmqpStr8UTF8(bytes));
        }
    }
}
