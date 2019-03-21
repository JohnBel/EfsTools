using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class QmslTxLinV3PwrsType
    {
        [ElementsCount(64)]
        [ElementType("int16")]
        [Description("")]
        public short[] Pwr { get; set; }
        
    }
}
