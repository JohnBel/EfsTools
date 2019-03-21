using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025581", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC2Gsm900EnhAptI
    {
        [ElementsCount(1)]
        [ElementType("GSM_TX_ENH_APT_DATA_TYPE")]
        [Description("")]
        public GsmTxEnhAptDataType EnhAptData { get; set; }
        
    }
}
