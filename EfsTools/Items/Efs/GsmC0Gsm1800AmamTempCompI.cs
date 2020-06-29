using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025038", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC0Gsm1800AmamTempComp
    {
        [FieldCount(16)]
        public sbyte[] AmamTempComp { get; set; }
    }
}