using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020896", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB8C1RxGainVsFreqI
    {
        [ElementsCount(128)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] Value { get; set; }
        
    }
}
