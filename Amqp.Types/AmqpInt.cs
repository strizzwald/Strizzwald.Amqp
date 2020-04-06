using System;

namespace Amqp.Types
{
    public struct AmqpInt
    {
        private readonly int _value;
        
        public AmqpInt(byte[] encoded)
        {
            if (encoded.Length != sizeof(uint))
                throw new ArgumentOutOfRangeException(nameof(encoded));

            _value = BitConverter.ToInt16(encoded, 0);
        }

        public int ToInt()
        {
            return _value;
        }
    }
}