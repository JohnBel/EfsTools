using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    internal class ItemsBinarySerializerException : Exception
    {
        public ItemsBinarySerializerException(string message)
            : base(message)
        {
        }
    }

    public static class ItemsBinarySerializer
    {
        public static void Serialize<T>(T obj, Stream stream)
        {
            var type = obj.GetType();
            var properies = type.GetProperties();
            foreach (var property in properies)
            {
                var elemType = property.GetCustomAttributes(typeof(ElementTypeAttribute)).FirstOrDefault();
                if (elemType != null)
                {
                    //var optional = (OptionalAttribute)property.GetCustomAttributes(typeof(OptionalAttribute)).FirstOrDefault();
                    var propType = property.PropertyType;
                    if (propType.IsArray)
                    {
                        var elemCount = (ElementsCountAttribute)property.GetCustomAttributes(typeof(ElementsCountAttribute)).FirstOrDefault();
                        if (elemCount != null)
                        {
                            var val = (IEnumerable)property.GetValue(obj);
                            bool addEndLine = false;
                            foreach (var item in val)
                            {
                                if (addEndLine && propType.Name == "String[]")
                                {
                                    var b = (byte)'\n';
                                    stream.WriteByte(b);
                                }
                                addEndLine = true;
                                var buf = GetBytes(item, item.GetType());
                                if (buf.Length > 0)
                                {
                                    stream.Write(buf, 0, buf.Length);
                                }
                            }
                        }
                    }
                    else
                    {
                        var val = property.GetValue(obj);
                        var buf = GetBytes(val, propType);
                        stream.Write(buf, 0, buf.Length);
                    }
                }
            }
        }

        public static void Deserialize<T>(T obj, Stream stream)
        {
            var type = obj.GetType();
            var properies = type.GetProperties();
            foreach (var property in properies)
            {
                var elemType = property.GetCustomAttributes(typeof(ElementTypeAttribute)).FirstOrDefault();
                if (elemType != null)
                {
                    var optional = (OptionalAttribute)property.GetCustomAttributes(typeof(OptionalAttribute)).FirstOrDefault();
                    var propType = property.PropertyType;
                    if (propType.IsArray)
                    {
                        var elemCount = (ElementsCountAttribute)property.GetCustomAttributes(typeof(ElementsCountAttribute)).FirstOrDefault();
                        if (elemCount != null)
                        {
                            var size = GetArrayElementTypeSize(propType);
                            if (size == 0)
                            {
                                size = (int)stream.Length;
                            }
                            var buf = (elemCount.Value == 0) ? new byte[stream.Length] : new byte[size * elemCount.Value];
                            var pos = 0;
                            while (stream.Position < stream.Length)
                            {
                                var read = stream.Read(buf, pos, buf.Length - pos);
                                pos += read;
                                if (read == 0)
                                {
                                    break;
                                }
                            }
                            
                            if (pos < buf.Length)
                            {
                                if (optional == null)
                                {
                                    throw new ItemsBinarySerializerException(
                                        $"Error on deserialize item '{type.Name}'. (Property = '{property.Name}')");
                                }
                                continue;
                            }
                            var val = GetArrayValue(propType, buf);
                            property.SetValue(obj, val);
                        }
                    }
                    else
                    {
                        var size = GetTypeSize(propType);
                        var buf = new byte[size];
                        var read = stream.Read(buf, 0, buf.Length);
                        if (read < buf.Length)
                        {
                            if (optional == null)
                            {
                                throw new ItemsBinarySerializerException(
                                    $"Error on deserialize item '{type.Name}'. (Property = '{property.Name}')");
                            }
                            continue;
                        }
                        var val = GetValue(propType, buf);
                        property.SetValue(obj, val);
                    }
                }
            }
        }

        private static byte ToByte(sbyte val)
        {
            byte res = 0;
            if (val >= 0)
            {
                res = (byte)val;
            }
            else
            {
                var b = (byte)(-val);
                b -= 1;
                res = (byte)((int)0xFF - (int)b);
            }
            return res;
        }

        private static byte[] GetBytes(object val, Type type)
        {
            byte[] result = null;
            switch (type.Name)
            {
                case "Char":
                    result = new byte[] { Convert.ToByte(val) };
                    break;
                case "Byte":
                    result = new byte[] { (byte)val };
                    break;
                case "SByte":
                    result = new byte[] { ToByte((sbyte)val) };
                    break;
                case "Int16":
                    result = BitConverter.GetBytes((short)val);
                    break;
                case "UInt16":
                    result = BitConverter.GetBytes((ushort)val);
                    break;
                case "Int32":
                    result = BitConverter.GetBytes((int)val);
                    break;
                case "UInt32":
                    result = BitConverter.GetBytes((uint)val);
                    break;
                case "Int64":
                    result = BitConverter.GetBytes((long)val);
                    break;
                case "UInt64":
                    result = BitConverter.GetBytes((ulong)val);
                    break;
                case "String":
                    result = Encoding.ASCII.GetBytes((string)val);
                    break;
                default:
                    break;
            }

            return result;
        }

        private static int GetTypeSize(Type type)
        {
            var size = 0;
            if (type.IsArray)
            {
                size = 0;
            }
            else
            {
                switch (type.Name)
                {
                    case "Char":
                    case "Byte":
                    case "SByte":
                        size = 1;
                        break;
                    case "Int16":
                    case "UInt16":
                        size = 2;
                        break;
                    case "Int32":
                    case "UInt32":
                        size = 4;
                        break;
                    case "Int64":
                    case "UInt64":
                        size = 8;
                        break;
                    case "String":
                        size = 0;
                        break;
                    default:
                        break;
                }
            }
            return size;
        }

        private static int GetArrayElementTypeSize(Type type)
        {
            var size = 0;
            if (type.IsArray)
            {
                switch (type.Name)
                {
                    case "Char[]":
                    case "Byte[]":
                    case "SByte[]":
                        size = 1;
                        break;
                    case "Int16[]":
                    case "UInt16[]":
                        size = 2;
                        break;
                    case "Int32[]":
                    case "UInt32[]":
                        size = 4;
                        break;
                    case "Int64[]":
                    case "UInt64[]":
                        size = 8;
                        break;
                    case "String[]":
                        size = 0;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                size = 0;
            }
            return size;
        }

        private static object GetValue(Type type, byte[] buf)
        {
            object result = null;
            if (!type.IsArray)
            {
                switch (type.Name)
                {
                    case "Char":
                        result = (char)buf[0];
                        break;
                    case "SByte":
                        result = (sbyte)buf[0];
                        break;
                    case "Byte":
                        result = buf[0];
                        break;
                    case "Int16":
                        result = BitConverter.ToInt16(buf, 0);
                        break;
                    case "UInt16":
                        result = BitConverter.ToUInt16(buf, 0);
                        break;
                    case "Int32":
                        result = BitConverter.ToInt32(buf, 0);
                        break;
                    case "UInt32":
                        result = BitConverter.ToUInt32(buf, 0);
                        break;
                    case "Int64":
                        result = BitConverter.ToInt64(buf, 0);
                        break;
                    case "UInt64":
                        result = BitConverter.ToUInt64(buf, 0);
                        break;
                    case "String":
                        result = Encoding.ASCII.GetString(buf);
                        break;
                    default:
                        break;
                }
            }
            return result;
        }

        private static object GetArrayValue(Type type, byte[] buf)
        {
            object result = null;
            if (type.IsArray)
            {
                switch (type.Name)
                {
                    case "Char[]":
                        {
                            var arr = new char[buf.Length];
                            for (var i = 0; i < arr.Length; ++i)
                            {
                                arr[i] = (char)buf[i];
                            }
                            result = arr;
                        }
                        break;
                    case "SByte[]":
                    {
                        var arr = new sbyte[buf.Length];
                        for (var i = 0; i < arr.Length; ++i)
                        {
                            arr[i] = (sbyte)buf[i];
                        }
                        result = arr;
                    }
                        break;
                    case "Byte[]":
                        result = buf;
                        break;
                    case "Int16[]":
                        {
                            var arr = new short[buf.Length / 2];
                            for (var i = 0; i < arr.Length; ++i)
                            {
                                arr[i] = BitConverter.ToInt16(buf, 2 * i);
                            }
                            result = arr;
                        }
                        break;
                    case "UInt16[]":
                        {
                            var arr = new ushort[buf.Length / 2];
                            for (var i = 0; i < arr.Length; ++i)
                            {
                                arr[i] = BitConverter.ToUInt16(buf, 2 * i);
                            }
                            result = arr;
                        }
                        break;
                    case "Int32[]":
                        {
                            var arr = new int[buf.Length / 4];
                            for (var i = 0; i < arr.Length; ++i)
                            {
                                arr[i] = BitConverter.ToInt32(buf, 4 * i);
                            }
                            result = arr;
                        }
                        break;
                    case "UInt32[]":
                        {
                            var arr = new uint[buf.Length / 4];
                            for (var i = 0; i < arr.Length; ++i)
                            {
                                arr[i] = BitConverter.ToUInt32(buf, 4 * i);
                            }
                            result = arr;
                        }
                        break;
                    case "Int64[]":
                        {
                            var arr = new long[buf.Length / 8];
                            for (var i = 0; i < arr.Length; ++i)
                            {
                                arr[i] = BitConverter.ToInt64(buf, 8 * i);
                            }
                            result = arr;
                        }
                        break;
                    case "UInt64[]":
                        {
                            var arr = new ulong[buf.Length / 8];
                            for (var i = 0; i < arr.Length; ++i)
                            {
                                arr[i] = BitConverter.ToUInt64(buf, 8 * i);
                            }
                            result = arr;
                        }
                        break;
                    case "String[]":
                    {
                        var str = Encoding.ASCII.GetString(buf);
                        result = str.Split(new char[] {'\n'}, StringSplitOptions.None).Select((p) => p.TrimEnd()).ToArray();
                    }
                        break;
                    default:
                        break;
                }
            }
            return result;
        }
    }
}
