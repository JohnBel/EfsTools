using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class QmslTxPwrImbalanceDbm10CoordinateType
    {
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short XAxisVal { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short YAxisVal { get; set; }
        
    }
}
