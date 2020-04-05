namespace Amqp.Types
{
    public struct AmqpNull : IAmqpType
    {
        public KnownAmqpType Value => KnownAmqpType.Null;

        public static object ToNull()
        {
            return null;
        }
    }
}