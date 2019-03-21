using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class GsmTxPolarRampProfileDataType
    {
        [ElementsCount(30)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] RampUp { get; set; }
        
        [ElementsCount(30)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] RampDown { get; set; }
        
    }
}
