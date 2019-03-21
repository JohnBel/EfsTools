using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class QmslTxEtDpdAmpmsType
    {
        [ElementsCount(16)]
        [ElementType("int32")]
        [Description("")]
        public int[] Ampm { get; set; }
        
    }
}
