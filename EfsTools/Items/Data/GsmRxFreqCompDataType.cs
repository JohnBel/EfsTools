using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class GsmRxFreqCompDataType
    {
        [ElementsCount(16)]
        [ElementType("int16")]
        [Description("")]
        public short[] FreqCompData { get; set; }
        
    }
}
