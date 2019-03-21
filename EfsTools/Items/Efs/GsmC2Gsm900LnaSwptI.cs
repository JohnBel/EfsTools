using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025001", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC2Gsm900LnaSwptI
    {
        [ElementsCount(1)]
        [ElementType("GSM_RX_LNA_SWPT_TYPE")]
        [Description("")]
        public GsmRxLnaSwptType GsmRxLnaSwpt { get; set; }
        
    }
}
