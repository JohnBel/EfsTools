using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class QmslTxCalLinearizerEptDpdTableNvType
    {
        [ElementsCount(64)]
        [ElementType("ept_dpd_struct")]
        [Description("")]
        public EptDpdStruct[] Dpd { get; set; }
        
    }
}
