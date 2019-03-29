using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Items.Data;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025092", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC0Gsm850TxRxAntTuner
    {
        [ElementsCount(1)]
        [ElementType("RFCOMMON_ANT_TUNER_DATA_TYPE")]
        [Description("")]
        public RfcommonAntTunerDataType AntTunerRx { get; set; }
        
        [ElementsCount(1)]
        [ElementType("RFCOMMON_ANT_TUNER_DATA_TYPE")]
        [Description("")]
        public RfcommonAntTunerDataType AntTunerTx { get; set; }
        
    }
}
