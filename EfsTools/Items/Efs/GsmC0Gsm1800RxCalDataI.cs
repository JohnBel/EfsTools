using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Items.Data;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024966", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC0Gsm1800RxCalData
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RxCalChanSize { get; set; }
        
        [ElementsCount(16)]
        [ElementType("int16")]
        [Description("")]
        public short[] RxCalChanList { get; set; }
        
        [ElementsCount(4)]
        [ElementType("GSM_RX_FREQ_COMP_DATA_TYPE")]
        [Description("")]
        public GsmRxFreqCompDataType[] RxFreqCompData { get; set; }
        
    }
}
