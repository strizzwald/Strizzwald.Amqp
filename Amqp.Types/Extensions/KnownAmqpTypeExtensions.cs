using System;

namespace Amqp.Types.Extensions
{
    public static class KnownAmqpTypeExtensions
    {
        public static bool TryGetNull(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.Null)
            {
                output = KnownAmqpType.Null;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetNull(this KnownAmqpType type, byte value)
        {
            if (type.TryGetNull(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetBool(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            switch ((KnownAmqpType) value)
            {
                case KnownAmqpType.Boolean:
                    output = KnownAmqpType.Boolean;
                    return true;
                case KnownAmqpType.BooleanFalse:
                    output = KnownAmqpType.BooleanFalse;
                    return true;
                case KnownAmqpType.BooleanTrue:
                    output = KnownAmqpType.BooleanTrue;
                    return true;
                default:
                    output = default;
                    return false;
            }
        }

        public static KnownAmqpType GetBool(this KnownAmqpType type, byte value)
        {
            if (type.TryGetBool(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetUShort(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.UShort)
            {
                output = KnownAmqpType.UShort;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetUShort(this KnownAmqpType type, byte value)
        {
            if (type.TryGetUShort(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetShort(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.Short)
            {
                output = KnownAmqpType.Short;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetShort(this KnownAmqpType type, byte value)
        {
            if (type.TryGetShort(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetUInt(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.UInt)
            {
                output = KnownAmqpType.UInt;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetUInt(this KnownAmqpType type, byte value)
        {
            if (type.TryGetUInt(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetInt(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.Int)
            {
                output = KnownAmqpType.Int;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetInt(this KnownAmqpType type, byte value)
        {
            if (type.TryGetInt(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetSmallUInt(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.SmallUInt)
            {
                output = KnownAmqpType.SmallUInt;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetSmallUInt(this KnownAmqpType type, byte value)
        {
            if (type.TryGetSmallUInt(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetSmallInt(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.SmallInt)
            {
                output = KnownAmqpType.SmallInt;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetSmallInt(this KnownAmqpType type, byte value)
        {
            if (type.TryGetSmallInt(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetUInt0(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.UInt0)
            {
                output = KnownAmqpType.UInt0;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetUInt0(this KnownAmqpType type, byte value)
        {
            if (type.TryGetUInt0(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetULong(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.ULong)
            {
                output = KnownAmqpType.ULong;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetULong(this KnownAmqpType type, byte value)
        {
            if (type.TryGetULong(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetSmallULong(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.SmallULong)
            {
                output = KnownAmqpType.SmallULong;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetSmallULong(this KnownAmqpType type, byte value)
        {
            if (type.TryGetSmallULong(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetULong0(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.ULong0)
            {
                output = KnownAmqpType.ULong0;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetULong0(this KnownAmqpType type, byte value)
        {
            if (type.TryGetULong0(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(output));
        }

        public static bool TryGetLong(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.Long)
            {
                output = KnownAmqpType.Long;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetLong(this KnownAmqpType type, byte value)
        {
            if (type.TryGetLong(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetSmallLong(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.SmallLong)
            {
                output = KnownAmqpType.SmallLong;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetSmallLong(this KnownAmqpType type, byte value)
        {
            if (type.TryGetSmallLong(value, out KnownAmqpType output))
                return KnownAmqpType.SmallLong;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetByte(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.Byte)
            {
                output = KnownAmqpType.Byte;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetByte(this KnownAmqpType type, byte value)
        {
            if (type.TryGetByte(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetFloat(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.Float)
            {
                output = KnownAmqpType.Float;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetFloat(this KnownAmqpType type, byte value)
        {
            if (type.TryGetFloat(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetDouble(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.Double)
            {
                output = KnownAmqpType.Double;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetDouble(this KnownAmqpType type, byte value)
        {
            if (type.TryGetDouble(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetDecimal32(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.Decimal32)
            {
                output = KnownAmqpType.Decimal32;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetDecimal32(this KnownAmqpType type, byte value)
        {
            if (type.TryGetDecimal32(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetDecimal64(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.Decimal64)
            {
                output = KnownAmqpType.Decimal64;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetDecimal64(this KnownAmqpType type, byte value)
        {
            if (type.TryGetDecimal64(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetDecimal128(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.Decimal128)
            {
                output = KnownAmqpType.Decimal128;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetDecimal128(this KnownAmqpType type, byte value)
        {
            if (type.TryGetDecimal128(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetChar(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.Char)
            {
                output = KnownAmqpType.Char;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetChar(this KnownAmqpType type, byte value)
        {
            if (type.TryGetChar(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetTimestamp(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.Timestamp)
            {
                output = KnownAmqpType.Timestamp;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetTimestamp(this KnownAmqpType type, byte value)
        {
            if (type.TryGetTimestamp(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetUUID(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.UUID)
            {
                output = KnownAmqpType.UUID;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetUUID(this KnownAmqpType type, byte value)
        {
            if (type.TryGetUUID(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetVBin8(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.VBin8)
            {
                output = KnownAmqpType.VBin8;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetVBin8(this KnownAmqpType type, byte value)
        {
            if (type.TryGetVBin8(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetVBin32(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.VBin32)
            {
                output = KnownAmqpType.VBin32;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetVBin32(this KnownAmqpType type, byte value)
        {
            if (type.TryGetVBin32(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetStr8UTF8(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.Str8UTF8)
            {
                output = KnownAmqpType.Str8UTF8;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetStr8UTF8(this KnownAmqpType type, byte value)
        {
            if (type.TryGetStr8UTF8(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetStr32UTF8(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.Str32UTF8)
            {
                output = KnownAmqpType.Str32UTF8;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetStr32UTF8(this KnownAmqpType type, byte value)
        {
            if (type.TryGetStr32UTF8(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetSym8(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.Sym8)
            {
                output = KnownAmqpType.Sym8;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetSym8(this KnownAmqpType type, byte value)
        {
            if (type.TryGetSym8(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetSym32(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.Sym32)
            {
                output = KnownAmqpType.Sym32;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetSym32(this KnownAmqpType type, byte value)
        {
            if (type.TryGetSym32(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetList0(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.List0)
            {
                output = KnownAmqpType.List0;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetList0(this KnownAmqpType type, byte value)
        {
            if (type.TryGetList0(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetList8(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.List8)
            {
                output = KnownAmqpType.List8;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetList8(this KnownAmqpType type, byte value)
        {
            if (type.TryGetList8(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetMap8(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.Map8)
            {
                output = KnownAmqpType.Map8;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetMap8(this KnownAmqpType type, byte value)
        {
            if (type.TryGetMap8(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetMap32(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.Map32)
            {
                output = KnownAmqpType.Map32;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetMap32(this KnownAmqpType type, byte value)
        {
            if (type.TryGetMap32(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetArray8(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.Array8)
            {
                output = KnownAmqpType.Array8;
                return true;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetArray8(this KnownAmqpType type, byte value)
        {
            if (type.TryGetArray8(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }

        public static bool TryGetArray32(this KnownAmqpType type, byte value, out KnownAmqpType output)
        {
            if (value == (byte) KnownAmqpType.Array32)
            {
                output = KnownAmqpType.Array32;
                return false;
            }

            output = default;
            return false;
        }

        public static KnownAmqpType GetArray32(this KnownAmqpType type, byte value)
        {
            if (type.TryGetArray32(value, out KnownAmqpType output))
                return output;

            throw new InvalidOperationException(nameof(value));
        }
    }
}