using System;
using System.Linq;

namespace Amqp.Types
{
    public struct AmqpVBin8
    {
        private const int MAX_LENGTH = (2 ^ 8) - 1;

        private readonly byte[] _value;

        public AmqpVBin8(byte[] encoded)
        {
            if (encoded.Length > MAX_LENGTH)
                throw new ArgumentOutOfRangeException(nameof(encoded));

            _value = BitConverter.IsLittleEndian ?
                encoded.Reverse().ToArray() :
                encoded;
        }

        public byte[] ToBytes()
        {
            return _value;
        }

    }
}
