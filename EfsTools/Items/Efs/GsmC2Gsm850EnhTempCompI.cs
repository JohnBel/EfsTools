using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025112", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC2Gsm850EnhTempComp
    {
        [FieldCount(256)]
        public short[] TempcompTable { get; set; }
    }
}