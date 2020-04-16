using System;
using System.Linq;

namespace Amqp.Types
{
    public struct AmqpVBin32
    {
        private const int MAX_LENGTH = (2 ^ 32) - 1;

        private readonly byte[] _value;

        public AmqpVBin32(byte[] encoded)
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
