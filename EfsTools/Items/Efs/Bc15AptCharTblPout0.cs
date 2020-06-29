using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021175", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc15AptCharTblPout0
    {
        [FieldCount(64)]
        public short[] Value
        {
            get;
        }
    }
}