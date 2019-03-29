using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024793", true, 0xE1FF)]
    [Attributes(9)]
    public class CdmaC0Bc14HdetModRange
    {
        [ElementsCount(8)]
        [ElementType("int16")]
        [Description("")]
        public short[] LowerBoundOffset { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int16")]
        [Description("")]
        public short[] UpperBoundOffset { get; set; }
        
    }
}
