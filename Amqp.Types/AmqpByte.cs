namespace Amqp.Types
{
    public struct AmqpByte
    {
        private readonly byte _value;

        public AmqpByte(byte value)
        {
            _value = value;
        }

        public byte ToByte()
        {
            return _value;
        }
    }
}