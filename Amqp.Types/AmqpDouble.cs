using System;

namespace Amqp.Types
{
    public struct AmqpDouble
    {
        private readonly double _value;

        public AmqpDouble(byte[] encoded)
        {
            if (encoded.Length != sizeof(double))
                throw new ArgumentOutOfRangeException(nameof(encoded));

            _value = BitConverter.ToDouble(encoded, 0);
        }

        public double ToDouble()
        {
            return _value;
        }
    }
}