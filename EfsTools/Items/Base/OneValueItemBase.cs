using System;
using BinarySerialization;

namespace EfsTools.Items.Base
{
    [Serializable]
    
    public class OneValueItemBase<T> : ItemBase
    {
        [FieldOffset(0)]
        public T Value
        {
            get; set;
        }
    }

    public class ByteItemBase : OneValueItemBase<byte> { }
    public class SByteItemBase : OneValueItemBase<sbyte> { }
    public class Int16ItemBase : OneValueItemBase<short> { }
    public class UInt16ItemBase : OneValueItemBase<ushort> { }
    public class Int32ItemBase : OneValueItemBase<int> { }
    public class UInt32ItemBase : OneValueItemBase<uint> { }
    public class Int64ItemBase : OneValueItemBase<long> { }
    public class UInt64ItemBase : OneValueItemBase<ulong> { }
    public class StringItemBase : OneValueItemBase<string> { }
}