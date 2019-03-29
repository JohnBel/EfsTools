using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025431", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC2Gsm900PaRangeMap
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte PaRangeMap { get; set; }
        
    }
}
