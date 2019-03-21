using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025085", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC0Gsm900SmpsPdmTblI
    {
        [ElementsCount(1)]
        [ElementType("GSM_TX_SMPS_PDM_DATA_TYPE")]
        [Description("")]
        public GsmTxSmpsPdmDataType SmpsPdmData { get; set; }
        
    }
}
