using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024166", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB11TxEptDpdConfigParams
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}