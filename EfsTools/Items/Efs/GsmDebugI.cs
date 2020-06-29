using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025584", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmDebug
    {
        [FieldCount(2)]
        public uint[] SpareNv { get; set; }
    }
}