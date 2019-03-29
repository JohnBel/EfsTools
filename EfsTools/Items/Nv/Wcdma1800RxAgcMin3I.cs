using System;
using System.ComponentModel;
using EfsTools.Attributes;


namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2862)]
    [Attributes(9)]
    public class Wcdma1800RxAgcMin3I
    {
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short Value { get; set; }
        
    }
}
