using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021560", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Wcdma1900PaCompensateUpR3VsFreq
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}