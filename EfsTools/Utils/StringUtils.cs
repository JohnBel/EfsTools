using System;
using System.Collections.Generic;
using System.Text;
using EfsTools.Attributes;

namespace EfsTools.Utils
{
    internal static class StringUtils
    {
        public static string GetString(byte[] data)
        {
            if (data == null)
            {
                return string.Empty;
            }

            var len = 0;
            foreach (var b in data)
            {
                if (b == 0)
                {
                    break;
                }

                ++len;
            }

            return Encoding.ASCII.GetString(data, 0, len);
        }

        private static byte[] GetLineEnding(LineEnding lineEnding)
        {
            byte[] result;
            switch (lineEnding)
            {
                case LineEnding.Windows:
                    result = new byte[]
                    {
                        10, 13
                    };
                    break;
                case LineEnding.Linux:
                    result = new byte[]
                    {
                        13
                    };
                    break;
                case LineEnding.MacOs:
                    result = new byte[]
                    {
                        10
                    };
                    break;
                default:
                    result = new byte[]
                    {
                        13
                    };
                    break;
            }

            return result;
        }

        private static string GetLineEndingString(LineEnding lineEnding)
        {
            string result;
            switch (lineEnding)
            {
                case LineEnding.Windows:
                    result = "\r\n";
                    break;
                case LineEnding.Linux:
                    result = "\n";
                    break;
                case LineEnding.MacOs:
                    result = "\r";
                    break;
                default:
                    result = "\n";
                    break;
            }

            return result;
        }

        public static string[] GetStringLines(byte[] data, LineEnding lineEnding)
        {
            if (data == null)
            {
                return new string[0];
            }

            var endLineBuf = GetLineEnding(lineEnding);
            var index = 0;
            var beforeEndLineIndex = 0;
            var endLineBufIndex = 0;
            var result = new List<string>();
            while (index < data.Length)
            {
                for (var i = index; index < data.Length; ++i)
                {
                    if (endLineBufIndex < endLineBuf.Length)
                    {
                        if (endLineBuf[endLineBufIndex] == data[i])
                        {
                            if (endLineBufIndex == 0)
                            {
                                beforeEndLineIndex = i;
                            }

                            ++endLineBufIndex;
                        }
                        else
                        {
                            if (endLineBufIndex >= endLineBuf.Length)
                            {
                                var str = Encoding.ASCII.GetString(data, index, beforeEndLineIndex - index);
                                result.Add(str);
                                index = i;
                                beforeEndLineIndex = i;
                            }

                            endLineBufIndex = 0;
                        }
                    }
                }

                if (index < data.Length)
                {
                    var str = Encoding.ASCII.GetString(data, index, data.Length - index);
                    result.Add(str);
                }
            }

            return result.ToArray();
        }


        public static string[] GetStringLines(string data, LineEnding lineEnding)
        {
            if (data == null)
            {
                return new string[0];
            }

            var endLineString = GetLineEndingString(lineEnding);
            var index = 0;
            var beforeEndLineIndex = 0;
            var endLineBufIndex = 0;
            var result = new List<string>();
            while (index < data.Length)
            {
                for (var i = index; index < data.Length; ++i)
                {
                    if (endLineBufIndex < endLineString.Length)
                    {
                        if (endLineString[endLineBufIndex] == data[i])
                        {
                            if (endLineBufIndex == 0)
                            {
                                beforeEndLineIndex = i;
                            }

                            ++endLineBufIndex;
                        }
                        else
                        {
                            if (endLineBufIndex >= endLineString.Length)
                            {
                                var str = data.Substring(index, beforeEndLineIndex - index);
                                result.Add(str);
                                index = i;
                                beforeEndLineIndex = i;
                            }

                            endLineBufIndex = 0;
                        }
                    }
                }

                if (index < data.Length)
                {
                    var str = data.Substring(index, data.Length - index);
                    result.Add(str);
                }
            }

            return result.ToArray();
        }

        public static byte[] GetBytes(string[] lines, LineEnding lineEnding)
        {
            var endLineBuf = GetLineEnding(lineEnding);
            var result = new List<byte>();
            foreach (var line in lines)
            {
                result.AddRange(Encoding.ASCII.GetBytes(line));
                result.AddRange(endLineBuf);
            }

            return result.ToArray();
        }

        public static string GetString(string[] lines, LineEnding lineEnding)
        {
            var endLineString = GetLineEndingString(lineEnding);
            var result = new StringBuilder();
            var addComma = false;
            foreach (var line in lines)
            {
                if (addComma)
                {
                    result.Append(endLineString);
                }
                addComma = true;
                result.Append(line);
            }

            return result.ToString();
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
            {
                Array.Copy(Encoding.ASCII.GetBytes(str), 0, buf, 0, Math.Min(size, str.Length));
            }

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