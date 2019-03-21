using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024173", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB21TxEptDpdConfigParamsI
    {
        [ElementsCount(32)]
        [ElementType("uint32")]
        [Description("")]
        public uint[] Value { get; set; }
        
    }
}
