using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022917", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15DoBc15Sar
    {
        [FieldCount(10)]
        public short[] Value
        {
            get;
        }
    }
}