using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022749", true, 0xE1FF)]
    [Attributes(9)]
    public class WcdmaB5TxLinVsTemp1AddlI
    {
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] F0CompVsTemp { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] F1CompVsTemp { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] F2CompVsTemp { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] F3CompVsTemp { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] F4CompVsTemp { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] F5CompVsTemp { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] F6CompVsTemp { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] F7CompVsTemp { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] F8CompVsTemp { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] F9CompVsTemp { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] F10CompVsTemp { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] F11CompVsTemp { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] F12CompVsTemp { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] F13CompVsTemp { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] F14CompVsTemp { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] F15CompVsTemp { get; set; }
        
    }
}
