using System;
using Amqp.Types.Extensions;
    
namespace Amqp.Types
{
    public struct AmqpBool
    {
        private readonly bool _value;
        
        public AmqpBool(byte encoded)
        {
            _value = (AmqpBoolEncodings) encoded switch
            {
                AmqpBoolEncodings.False => false,
                AmqpBoolEncodings.True => true,
                _ => throw new InvalidOperationException(nameof(encoded))
            };
        }
        
        public bool ToBool()
        {
            return _value;
        }
    }

    internal enum AmqpBoolEncodings
    {
        False = 0x00,
        True = 0x01
    }
}