using System;
   using Amqp.Types.Extensions;
   
   namespace Amqp.Types
   {
       public struct AmqpChar
       {
           private readonly char _value;
   
           public AmqpChar(byte encoded)
           {
               _value = BitConverter.ToChar(new[] { encoded }, 0);
           }

           public char ToChar()
           {
               return _value;
           }
       }
   }