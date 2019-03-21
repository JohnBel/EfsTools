using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class QmslTxCalLinearizerTableNvType
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort TxChain { get; set; }
        
        [ElementsCount(64)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] Rgi { get; set; }
        
        [ElementsCount(64)]
        [ElementType("int16")]
        [Description("")]
        public short[] Power { get; set; }
        
        [ElementsCount(64)]
        [ElementType("uint32")]
        [Description("")]
        public uint[] Apt { get; set; }
        
    }
}
