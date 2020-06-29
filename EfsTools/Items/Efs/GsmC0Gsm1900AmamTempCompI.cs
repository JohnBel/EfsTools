using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025039", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC0Gsm1900AmamTempComp
    {
        [FieldCount(16)]
        public sbyte[] AmamTempComp { get; set; }
    }
}