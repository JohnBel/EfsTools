using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025012", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC0Gsm850KvCalI
    {
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint KvCalValue { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort KvCalLowChan { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort KvCalHighChan { get; set; }
        
    }
}
