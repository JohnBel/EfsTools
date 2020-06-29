using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022279", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB24TxGainIndexForApt3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}