using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/nas/forced_irat", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class ForcedIrat
    {
        public byte Value { get; set; }
    }
}