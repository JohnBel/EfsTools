using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024841", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB17C2LnaRangeRiseFallI
    {
        [ElementsCount(32)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
