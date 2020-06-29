using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025108", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC0Gsm850EnhTempComp
    {
        [FieldCount(256)]
        public short[] TempcompTable { get; set; }
    }
}