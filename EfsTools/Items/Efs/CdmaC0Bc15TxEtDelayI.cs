using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025514", true, 0xE1FF)]
    [Attributes(9)]
    public class CdmaC0Bc15TxEtDelay
    {
        [ElementsCount(1)]
        [ElementType("int32")]
        [Description("")]
        public int Delay { get; set; }
        
    }
}
