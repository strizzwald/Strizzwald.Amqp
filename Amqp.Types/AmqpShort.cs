using System;
using System.Net;

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

            if (BitConverter.IsLittleEndian)
            {
                _value = IPAddress.HostToNetworkOrder(_value);
            }

            _value = BitConverter.IsLittleEndian
                ? IPAddress.HostToNetworkOrder(BitConverter.ToInt16(encoded, 0))
                : BitConverter.ToInt16(encoded, 0);
        }

        public short ToShort()
        {
            return _value;
        }
    }
}