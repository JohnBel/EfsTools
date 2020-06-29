using System;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025044", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC0Gsm850TempComp
    {
        public GsmTxTempCompDataType TempCompData { get; set; }
    }
}