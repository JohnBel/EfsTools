using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022593", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class B11AptCharTblPout0
    {
        [FieldCount(64)]
        public short[] Value
        {
            get;
        }
    }
}