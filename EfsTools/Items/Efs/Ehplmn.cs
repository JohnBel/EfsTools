using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/nas/ehplmn", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Ehplmn
    {
        [FieldCount(61)]
        public byte[] Value { get; set; }
    }
}