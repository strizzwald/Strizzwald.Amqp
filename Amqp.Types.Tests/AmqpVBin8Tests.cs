﻿using System;
using System.Linq;
using NUnit.Framework;

namespace Amqp.Types.Tests
{
    [TestFixture]
    public class AmqpVBin8Tests
    {
        [Test]
        public void AmqpVBin8_ReturnsBytes()
        {
            byte[] bytes = new byte[] { 0x00, 0x00, 0x00, 0x01 };

            var amqpVBin8 = new AmqpVBin8(bytes);

            if (BitConverter.IsLittleEndian)
            {
                Assert.AreEqual(bytes.Reverse().ToArray(), amqpVBin8.ToBytes());
            }
            else
            {
                Assert.AreEqual(bytes, amqpVBin8.ToBytes());
            }

        }

        [Test]
        public void AmqpVBin8_ThrowsException()
        {
            var MAX_VALUE = (ushort)Math.Pow(2, 8);
            var bytes = new byte[MAX_VALUE];

            for (var i = 0; i < MAX_VALUE; i++)
            {
                bytes[i] = 0x00;
            }

            Assert.Throws<ArgumentOutOfRangeException>(() => new AmqpVBin8(bytes));
        }
    }
}
