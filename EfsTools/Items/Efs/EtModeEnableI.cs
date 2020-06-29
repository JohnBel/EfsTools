using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020787", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class EtModeEnable
    {
        public byte Value { get; set; }
    }
}