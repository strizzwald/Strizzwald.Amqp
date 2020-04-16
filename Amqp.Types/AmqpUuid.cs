using System;

namespace Amqp.Types
{
    public struct AmqpUuid
    {
        private readonly Guid _amqpUuid;

        public AmqpUuid(byte[] encoded)
        {
            const int uuidLength = 16;

            if (encoded.Length != uuidLength)
                throw new ArgumentOutOfRangeException(nameof(encoded));

            _amqpUuid = new Guid(encoded);
        }

        public Guid ToGuid()
        {
            return _amqpUuid;
        }
    }
}