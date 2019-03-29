using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024989", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC0Gsm900PaSwpt
    {
        [ElementsCount(1)]
        [ElementType("GSM_TX_PA_SWPT_DATA_TYPE")]
        [Description("")]
        public GsmTxPaSwptDataType GsmPaSwptData { get; set; }
        
    }
}
