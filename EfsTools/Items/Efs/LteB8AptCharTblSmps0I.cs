using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021451", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB8AptCharTblSmps0
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}