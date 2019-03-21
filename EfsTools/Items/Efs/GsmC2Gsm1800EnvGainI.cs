using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025010", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC2Gsm1800EnvGainI
    {
        [ElementsCount(32)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] EnvGainFreqRgiF1 { get; set; }
        
        [ElementsCount(32)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] EnvGainFreqRgiF2 { get; set; }
        
        [ElementsCount(32)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] EnvGainFreqRgiF3 { get; set; }
        
    }
}
