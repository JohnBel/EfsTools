using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025079", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC0Gsm1900PowerLevels
    {
        [FieldCount(16)]
        public short[] GsmPowerLevels { get; set; }
    }
}