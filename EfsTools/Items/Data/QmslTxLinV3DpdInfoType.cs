using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class QmslTxLinV3DpdInfoType
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte DpdTypeUsed { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort NumDpdUsed { get; set; }
        
        [ElementsCount(64)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] DpdIdx { get; set; }
        
    }
}
