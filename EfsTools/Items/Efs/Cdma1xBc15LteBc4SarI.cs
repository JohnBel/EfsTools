using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022925", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteBc4Sar
    {
        [FieldCount(10)]
        public short[] Value
        {
            get;
        }
    }
}