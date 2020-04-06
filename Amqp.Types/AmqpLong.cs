using System;

namespace Amqp.Types
{
    public struct AmqpLong
    {
        private readonly long _value;

        public AmqpLong(byte[] encoded)
        {
            if (encoded.Length != sizeof(long))
                throw new ArgumentOutOfRangeException(nameof(encoded));

            _value = BitConverter.ToInt64(encoded, 0);
        }

        public long ToLong()
        {
            return _value;
        }
    }
}