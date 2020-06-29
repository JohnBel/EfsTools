using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024860", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33TxRotAnglePaState
    {
        [FieldCount(8)]
        public ushort[] TxRotAnglePaState { get; set; }
    }
}