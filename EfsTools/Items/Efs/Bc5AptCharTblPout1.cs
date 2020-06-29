using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021121", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc5AptCharTblPout1
    {
        [FieldCount(64)]
        public short[] Value
        {
            get;
        }
    }
}