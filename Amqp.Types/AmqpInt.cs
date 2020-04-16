using System;
using System.Net;

namespace Amqp.Types
{
    public struct AmqpInt
    {
        private readonly int _value;
        
        public AmqpInt(byte[] encoded)
        {
            if (encoded.Length != sizeof(int))
                throw new ArgumentOutOfRangeException(nameof(encoded));

            _value = BitConverter.IsLittleEndian
                ? IPAddress.NetworkToHostOrder(BitConverter.ToInt32(encoded, 0))
                : BitConverter.ToInt32(encoded, 0);

        }

        public int ToInt()
        {
            return _value;
        }
    }
}