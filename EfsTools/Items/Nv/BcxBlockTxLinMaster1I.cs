using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4553)]
    [Attributes(9)]
    public class BcxBlockTxLinMaster1I
    {
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short Value1 { get; set; }
        
        [ElementsCount(37)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value2 { get; set; }
        
    }
}
