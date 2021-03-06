﻿using System;
using System.Text;

namespace Amqp.Types
{
    public struct AmqpStr32UTF8
    {
        private static readonly uint MAX_VALUE = (uint)Math.Pow(2, 32) - 1;
        private readonly string _value;

        public AmqpStr32UTF8(byte[] encoded)
        {
            if (encoded.Length > MAX_VALUE)
                throw new ArgumentOutOfRangeException(nameof(encoded));

            _value = Encoding.UTF8.GetString(encoded);
        }

        public override string ToString()
        {
            return _value;
        }
    }
}
