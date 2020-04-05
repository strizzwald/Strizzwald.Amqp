using System;

namespace Amqp.Types
{
    public interface IAmqpType
    {
        KnownAmqpType Value { get; }
    }
}