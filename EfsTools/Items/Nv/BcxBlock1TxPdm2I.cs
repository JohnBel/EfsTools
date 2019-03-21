using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6192)]
    [Attributes(9)]
    public class BcxBlock1TxPdm2I
    {
        [ElementsCount(64)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
