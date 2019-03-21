using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023205", true, 0xE1FF)]
    [Attributes(9)]
    public class CdmaC2Bc1TxMultiLinAptAdjI
    {
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte Reserved { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjPilot { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjRc1rc2 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjRc3rc4V { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjRc3rc4D { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjRc8V { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjRc8D { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjDor0Pilot { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjDor01 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjDor02 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjDor03 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjDor04 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjDor05 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjDoraPs0 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjDoraPs1 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjDoraPs2 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjDoraPs3 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjDoraPs4 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjDoraPs5 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjDoraPs6 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjDoraPs7 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjDoraPs8 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjDoraPs9 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjDoraPs10 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjDoraPs11 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte PwrAdjDoraPs12 { get; set; }
        
    }
}
