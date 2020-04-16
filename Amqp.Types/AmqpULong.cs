using System;
using System.Linq;

namespace Amqp.Types
{
    public struct AmqpULong
    {
        private readonly ulong _value;
        
        public AmqpULong(byte[] encoded)
        {
            if (encoded.Length != sizeof(ulong))
                throw new ArgumentOutOfRangeException(nameof(encoded));

            _value = BitConverter.IsLittleEndian
                ? BitConverter.ToUInt64(encoded.Reverse().ToArray(), 0)
                : BitConverter.ToUInt64(encoded, 0);
        }

        public ulong ToULong()
        {
            return _value;
        }
    }
}