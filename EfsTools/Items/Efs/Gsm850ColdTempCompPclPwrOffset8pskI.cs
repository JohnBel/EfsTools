using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022889", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Gsm850ColdTempCompPclPwrOffset8psk
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}