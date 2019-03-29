using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024892", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB33C1RxGainVsFreq
    {
        [ElementsCount(128)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] C1RxGainVsFreq { get; set; }
        
    }
}
