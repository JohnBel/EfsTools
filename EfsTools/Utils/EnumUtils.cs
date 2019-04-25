using System;
using System.Globalization;
using System.IO;

namespace EfsTools.Utils
{
    internal static class EnumUtils
    {
        public static byte ParseEnumByte(Type enumType, string val)
        {
            try
            {
                if (string.IsNullOrEmpty(val))
                {
                    return 0;
                }
                if (val.StartsWith("0x") && byte.TryParse(val.Substring(2), 
                    NumberStyles.HexNumber, CultureInfo.InvariantCulture.NumberFormat, out byte b))
                {
                    return b;
                }
                if (val.Length < 4 && byte.TryParse(val, out byte b1))
                {
                    return b1;
                }
                return (byte)Enum.Parse(enumType, val, true);
            }
            catch
            {
                return 0;
            }
        }

        public static ushort ParseEnumUShort(Type enumType, string val)
        {
            try
            {
                if (string.IsNullOrEmpty(val))
                {
                    return 0;
                }
                if (val.StartsWith("0x") && ushort.TryParse(val.Substring(2), 
                    NumberStyles.HexNumber, CultureInfo.InvariantCulture.NumberFormat, out ushort b))
                {
                    return b;
                }
                if (val.Length < 6 && ushort.TryParse(val, out ushort b1))
                {
                    return b1;
                }
                return (ushort)Enum.Parse(enumType, val, true);
            }
            catch
            {
                return 0;
            }
        }

        public static int ParseEnumInt(Type enumType, string val)
        {
            try
            {
                if (string.IsNullOrEmpty(val))
                {
                    return 0;
                }
                if (val.StartsWith("0x") && int.TryParse(val.Substring(2), 
                    NumberStyles.HexNumber, CultureInfo.InvariantCulture.NumberFormat, out int b))
                {
                    return b;
                }
                if (val.Length < 10 && int.TryParse(val, out int b1))
                {
                    return b1;
                }
                return (int)Enum.Parse(enumType, val, true);
            }
            catch
            {
                return 0;
            }
        }
    }
}