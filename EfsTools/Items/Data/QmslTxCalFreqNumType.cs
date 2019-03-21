using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class QmslTxCalFreqNumType
    {
        [ElementsCount(16)]
        [ElementType("int16")]
        [Description("")]
        public short[] Freq { get; set; }
        
    }
}
