using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class RfcommonAntTunerDataType
    {
        [ElementsCount(4)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] DeviceEnable { get; set; }
        
        [ElementsCount(4)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] DeviceCs { get; set; }
        
        [ElementsCount(16)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] ChannelList { get; set; }
        
        [ElementsCount(64)]
        [ElementType("uint32")]
        [Description("")]
        public uint[] CodeWords { get; set; }
        
    }
}
