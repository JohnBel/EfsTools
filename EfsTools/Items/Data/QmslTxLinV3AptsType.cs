using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class QmslTxLinV3AptsType
    {
        [ElementsCount(64)]
        [ElementType("uint32")]
        [Description("")]
        public uint[] Apt { get; set; }
        
    }
}
