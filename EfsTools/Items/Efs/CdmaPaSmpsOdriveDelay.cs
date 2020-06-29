using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021306", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaPaSmpsOdriveDelay
    {
        public ushort Value { get; set; }
    }
}