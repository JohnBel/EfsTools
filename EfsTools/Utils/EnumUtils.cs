using System;
using System.Globalization;
using System.IO;

namespace EfsTools.Utils
{
    internal static class EnumUtils
    {
        public static byte ParseEnum(Type enumType, string val)
        {
            try
            {
                if (val.Length < 4 && byte.TryParse(val, out byte b))
                {
                    return b;
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
                if (val.Length < 6 && ushort.TryParse(val, out ushort b))
                {
                    return b;
                }
                return (ushort)Enum.Parse(enumType, val, true);
            }
            catch
            {
                return 0;
            }
        }
    }
}