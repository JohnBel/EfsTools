using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021967", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc6TxApt1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}