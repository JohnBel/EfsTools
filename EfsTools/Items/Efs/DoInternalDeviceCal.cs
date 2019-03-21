using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024125", true, 0xE1FF)]
    [Attributes(9)]
    public class DoInternalDeviceCal
    {
        [ElementsCount(1)]
        [ElementType("Tx_Int_Dev_Cal_NV_Type")]
        [Description("")]
        public TxIntDevCalNvType Value { get; set; }
        
    }
}
