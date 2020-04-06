using System;

namespace Amqp.Types
{
    public struct AmqpShort
    {
        private readonly short _value;

        public AmqpShort(byte[] encoded)
        {
            if (encoded.Length != sizeof(short))
                throw new ArgumentOutOfRangeException(nameof(encoded));

            _value = BitConverter.ToInt16(encoded, 0);
        }

        public short ToShort()
        {
            return _value;
        }
    }
}