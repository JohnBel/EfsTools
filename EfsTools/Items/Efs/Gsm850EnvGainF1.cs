using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022902", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Gsm850EnvGainF1
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}