using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3920)]
    [Attributes(9)]
    public class C1Bc11Lna2RiseI
    {
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte Value { get; set; }
        
    }
}
