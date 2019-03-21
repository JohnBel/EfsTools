using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025584", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmDebugI
    {
        [ElementsCount(2)]
        [ElementType("uint32")]
        [Description("")]
        public uint[] SpareNv { get; set; }
        
    }
}
