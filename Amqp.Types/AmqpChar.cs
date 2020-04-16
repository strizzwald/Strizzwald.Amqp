using System;
using System.Linq;

namespace Amqp.Types
   {
       public struct AmqpChar
       {
           private readonly char _value;
   
           public AmqpChar(byte[] encoded)
           {
               if (encoded.Length != 4)
                   throw new ArgumentOutOfRangeException(nameof(encoded));

               _value = BitConverter.IsLittleEndian
                   ? BitConverter.ToChar(encoded.Reverse().ToArray(), 0)
                   : BitConverter.ToChar(encoded, 0);

           }

           public char ToChar()
           {
               return _value;
           }
       }
   }