using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using BinarySerialization;
using EfsTools.Attributes;
using EfsTools.Utils;

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
        private static BinarySerializer _binarySerializer;

        private static BinarySerializer BinarySerializer
        {
            get
            {
                if (_binarySerializer == null)
                {
                    _binarySerializer = new BinarySerializer();
                }
                return _binarySerializer;
            }
        }
        public static void Serialize<T>(T obj, Stream stream)
        {
            if (obj != null)
            {
                BinarySerializer.Serialize(stream, obj);
            }
        }

        public static T Deserialize<T>(Stream stream)
        {
            var obj = Deserialize(stream, typeof(T));
            return (T)obj;
        }

        public static object Deserialize(Stream stream, Type type)
        {
            var obj = BinarySerializer.Deserialize(stream, type);
            return obj;
        }

    }
}