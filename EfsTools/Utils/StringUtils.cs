using System;
using System.Text;

namespace EfsTools.Utils
{
    internal static class StringUtils
    {
        public static string GetString(byte[] data)
        {
            var len = 0;
            foreach (var b in data)
            {
                if (b == 0) break;
                ++len;
            }

            return Encoding.ASCII.GetString(data, 0, len);
        }

        public static string GetStringWithZero(byte[] data)
        {
            var str = Encoding.ASCII.GetString(data);
            str = str.Replace("\0", "\\0");
            return str;
        }

        public static byte[] GetBytes(string str, int size)
        {
            var buf = new byte[size];
            if (!string.IsNullOrEmpty(str))
                Array.Copy(Encoding.ASCII.GetBytes(str), 0, buf, 0, Math.Min(size, str.Length));
            return buf;
        }

        public static byte[] GetBytesWithZero(string str, int size)
        {
            var buf = new byte[size];
            if (!string.IsNullOrEmpty(str))
            {
                var s = str.Replace("\\0", "\0");
                Array.Copy(Encoding.ASCII.GetBytes(s), 0, buf, 0, Math.Min(size, s.Length));
            }

            return buf;
        }
    }
}