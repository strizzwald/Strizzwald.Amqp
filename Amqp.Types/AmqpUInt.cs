using System;

namespace Amqp.Types
{
    public struct AmqpUInt
    {
        private readonly uint _value;

        public AmqpUInt(byte[] encoded)
        {
            if (encoded.Length != sizeof(uint))
                throw new ArgumentOutOfRangeException(nameof(encoded));

            _value = BitConverter.ToUInt16(encoded, 0);
        }

        public uint ToUInt()
        {
            return _value;
        }
    }
}