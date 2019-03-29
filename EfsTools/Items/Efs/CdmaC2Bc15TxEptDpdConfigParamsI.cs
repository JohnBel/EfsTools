using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024157", true, 0xE1FF)]
    [Attributes(9)]
    public class CdmaC2Bc15TxEptDpdConfigParams
    {
        [ElementsCount(1)]
        [ElementType("TX_XPT_DPD_CONFIG_PARAMS_DATA_TYPE")]
        [Description("")]
        public TxXptDpdConfigParamsDataType XptCfgParams { get; set; }
        
    }
}
