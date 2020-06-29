using System;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025577", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC0Gsm900EnhApt
    {
        public GsmTxEnhAptDataType EnhAptData { get; set; }
    }
}