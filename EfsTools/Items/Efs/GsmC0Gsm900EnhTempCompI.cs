using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025109", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC0Gsm900EnhTempComp
    {
        [FieldCount(256)]
        public short[] TempcompTable { get; set; }
    }
}