using System;

namespace Amqp.Types
{
    public struct AmqpFloat
    {
        private readonly float _value;

        public AmqpFloat(byte[] encoded)
        {
            if (encoded.Length != sizeof(float))
                throw new ArgumentOutOfRangeException(nameof(encoded));

            _value = BitConverter.ToSingle(encoded, 0);
        }

        public float ToFloat()
        {
            return _value;
        }
    }
}