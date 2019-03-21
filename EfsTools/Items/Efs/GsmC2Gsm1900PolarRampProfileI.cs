using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025123", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC2Gsm1900PolarRampProfileI
    {
        [ElementsCount(1)]
        [ElementType("GSM_TX_POLAR_RAMP_PROFILE_DATA_TYPE")]
        [Description("")]
        public GsmTxPolarRampProfileDataType PolarParampLut { get; set; }
        
    }
}
