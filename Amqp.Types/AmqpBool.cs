using System;
using Amqp.Types.Extensions;
    
namespace Amqp.Types
{
    public struct AmqpBool : IAmqpType
    {
        private readonly KnownAmqpType _value;
        public KnownAmqpType Value => _value == default ? KnownAmqpType.Boolean : _value;

        public AmqpBool(byte value)
        {
            _value = default(KnownAmqpType).GetBool(value);
        }

        public bool ToBool()
        {
            return Value switch
            {
                KnownAmqpType.Boolean => new bool(),
                KnownAmqpType.BooleanFalse => false,
                KnownAmqpType.BooleanTrue => true,
                _ => throw new InvalidOperationException()
            };

        }
    }
}