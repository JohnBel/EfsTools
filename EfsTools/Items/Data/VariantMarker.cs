using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class VariantMarker
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Version { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort NumOfElement { get; set; }
        
    }
}
