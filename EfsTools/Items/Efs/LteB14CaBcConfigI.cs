using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025221", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB14CaBcConfigI
    {
        [ElementsCount(1)]
        [ElementType("uint64")]
        [Description("")]
        public ulong Value { get; set; }
        
    }
}
