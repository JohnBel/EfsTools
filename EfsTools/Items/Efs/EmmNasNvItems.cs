using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/nas/emm_nas_nv_items", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class EmmNasNvItems
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}