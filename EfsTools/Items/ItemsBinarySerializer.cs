using System;
using System.Diagnostics;
using System.IO;
using BinarySerialization;
using EfsTools.Items.Base;
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
        private static BinarySerializer _binarySerializer;

        private static BinarySerializer BinarySerializer
        {
            get
            {
                if (_binarySerializer == null)
                {
                    _binarySerializer = new BinarySerializer();

                    if (Debugger.IsAttached)
                    {
                        _binarySerializer.MemberSerializing += (object sender, MemberSerializingEventArgs e)
                            => Debugger.Log(0, "info", $"StartSerialization: t: {e.Context.ParentType.Name}, m: {e.MemberName}, offset: {e.Offset}\n");
                        _binarySerializer.MemberSerialized += (object sender, MemberSerializedEventArgs e)
                            => Debugger.Log(0, "info", $"EndSerialization: t: {e.Context.ParentType.Name}, m: {e.MemberName}, v: {e.Value}, offset: {e.Offset}\n");
                        _binarySerializer.MemberDeserializing += (object sender, MemberSerializingEventArgs e)
                            => Debugger.Log(0, "info", $"StartDeserialization: t: {e.Context.ParentType.Name}, m: {e.MemberName}, offset: {e.Offset}\n");
                        _binarySerializer.MemberDeserialized += (object sender, MemberSerializedEventArgs e)
                            => Debugger.Log(0, "info", $"EndDeserialization: t: {e.Context.ParentType.Name}, m: {e.MemberName}, v: {e.Value}, offset: {e.Offset}\n");

                    }
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
            return (T) obj;
        }

        public static object Deserialize(Stream stream, Type type)
        {
            try
            {
                var obj = BinarySerializer.Deserialize(stream, type);
                return obj;
            }
            catch (Exception e)
            {
                return null;
            }
            
        }
    }
}