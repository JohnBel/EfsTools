using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class GsmEnhtempcompPclType
    {
        [ElementsCount(16)]
        [ElementType("int16")]
        [Description("")]
        public short[] PwrIndex { get; set; }
        
    }
}
