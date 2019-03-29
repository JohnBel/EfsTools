using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024901", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB33TxLimitVsFreqLpm
    {
        [ElementsCount(16)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] LteTxLimitVsFreqLpm { get; set; }
        
    }
}
