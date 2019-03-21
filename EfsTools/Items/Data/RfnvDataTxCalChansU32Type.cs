using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class RfnvDataTxCalChansU32Type
    {
        [ElementsCount(16)]
        [ElementType("uint32")]
        [Description("")]
        public uint[] TxCalChans { get; set; }
        
    }
}
