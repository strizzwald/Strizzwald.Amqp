using System;

namespace Amqp.Types
{
    public struct AmqpUShort
    {
        private readonly ushort _value;
        
        public AmqpUShort(byte[] encoded)
        {
            if (encoded.Length != sizeof(ushort))
                throw new ArgumentOutOfRangeException(nameof(encoded));

            _value = BitConverter.ToUInt16(encoded, 0);
        }

        public ushort ToUShort()
        {
            return _value;
        }

    }
}