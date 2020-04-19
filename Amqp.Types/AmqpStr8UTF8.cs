using System;
using System.Text;

namespace Amqp.Types
{
    public struct AmqpStr8UTF8
    {
        private static readonly ushort MAX_VALUE = (ushort)(Math.Pow(2, 8) - 1);
        private readonly string _value;

        public AmqpStr8UTF8(byte[] encoded)
        {
            if (encoded.Length > MAX_VALUE)
                throw new ArgumentOutOfRangeException(nameof(encoded));

            _value = Encoding.UTF8.GetString(encoded);
        }

        public override string ToString()
        {
            return _value;
        }
    }
}
