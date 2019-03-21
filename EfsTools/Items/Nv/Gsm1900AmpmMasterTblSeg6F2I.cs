using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2646)]
    [Attributes(9)]
    public class Gsm1900AmpmMasterTblSeg6F2I
    {
        [ElementsCount(32)]
        [ElementType("uint32")]
        [Description("")]
        public uint[] Value { get; set; }
        
    }
}
