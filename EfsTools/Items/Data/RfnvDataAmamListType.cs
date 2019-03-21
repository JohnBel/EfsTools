using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class RfnvDataAmamListType
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte AmamAmpmIdentifier { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ChannelIndex { get; set; }
        
        [ElementsCount(128)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] DataList { get; set; }
        
    }
}
