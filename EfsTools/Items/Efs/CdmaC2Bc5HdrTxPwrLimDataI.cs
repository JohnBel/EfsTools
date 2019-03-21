using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Items.Data;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023738", true, 0xE1FF)]
    [Attributes(9)]
    public class CdmaC2Bc5HdrTxPwrLimDataI
    {
        [ElementsCount(25)]
        [ElementType("QMSL_Tx_Pwr_Limit_Data_type")]
        [Description("")]
        public QmslTxPwrLimitDataType[] HdrTxPwrLimit { get; set; }
        
    }
}
