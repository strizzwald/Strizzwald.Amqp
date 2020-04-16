using System;
using System.Linq;
using System.Net;

namespace Amqp.Types
{
    public struct AmqpUInt
    {
        private readonly uint _value;

        public AmqpUInt(byte[] encoded)
        {
            if (encoded.Length != sizeof(uint))
                throw new ArgumentOutOfRangeException(nameof(encoded));

            _value = BitConverter.IsLittleEndian
                ? BitConverter.ToUInt32(encoded.Reverse().ToArray(), 0)
                : BitConverter.ToUInt32(encoded, 0);
        }

        public uint ToUInt()
        {
            return _value;
        }
    }
}