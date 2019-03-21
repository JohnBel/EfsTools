using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class QmslTxLinV3RgisType
    {
        [ElementsCount(64)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] Rgi { get; set; }
        
    }
}
