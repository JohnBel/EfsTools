using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7223)]
    [Attributes(9)]
    public class C1Wcdma2100LnaRangeOffset5Car1I
    {
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short Value { get; set; }
        
    }
}
