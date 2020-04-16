using System;
using System.Net;

namespace Amqp.Types
{
    public struct AmqpLong
    {
        private readonly long _value;

        public AmqpLong(byte[] encoded)
        {
            if (encoded.Length != sizeof(long))
                throw new ArgumentOutOfRangeException(nameof(encoded));

            _value = BitConverter.IsLittleEndian
                ? IPAddress.HostToNetworkOrder(BitConverter.ToInt64(encoded, 0))
                : BitConverter.ToInt64(encoded, 0);
        }

        public long ToLong()
        {
            return _value;
        }
    }
}