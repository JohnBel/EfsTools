using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022903", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Gsm850EnvGainF2
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}