using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024578", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB38TxLimVsTempVsFreqI
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte MatrixEnabled { get; set; }
        
        [ElementsCount(128)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] LimVsTempVsFreq { get; set; }
        
    }
}
