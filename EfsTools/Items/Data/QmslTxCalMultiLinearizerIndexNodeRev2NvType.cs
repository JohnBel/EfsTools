using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class QmslTxCalMultiLinearizerIndexNodeRev2NvType
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort UpperBoundChan { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte TableOffset { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte DpdTableOffset { get; set; }
        
    }
}
