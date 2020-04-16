using System;
using System.Net;

namespace Amqp.Types
{
    public struct AmqpTimestamp
    {
        private readonly DateTimeOffset _timestamp;

        public AmqpTimestamp(byte[] encoded)
        {
            
            if (encoded.Length != sizeof(long))
                throw new ArgumentOutOfRangeException(nameof(encoded));
            
            var passedMilliseconds = BitConverter.IsLittleEndian
                ? IPAddress.HostToNetworkOrder(BitConverter.ToInt64(encoded, 0))
                : BitConverter.ToInt64(encoded, 0);

            _timestamp = DateTimeOffset.FromUnixTimeMilliseconds(passedMilliseconds);
        }
        
        public DateTimeOffset ToDatetimeOffset()
        {
            return _timestamp;
        }
    }
}