using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025577", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC0Gsm900EnhApt
    {
        [ElementsCount(1)]
        [ElementType("GSM_TX_ENH_APT_DATA_TYPE")]
        [Description("")]
        public GsmTxEnhAptDataType EnhAptData { get; set; }
        
    }
}
