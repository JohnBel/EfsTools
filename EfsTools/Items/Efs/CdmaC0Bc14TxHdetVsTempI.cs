using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024761", true, 0xE1FF)]
    [Attributes(9)]
    public class CdmaC0Bc14TxHdetVsTemp
    {
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] HdetVsTemp { get; set; }
        
    }
}
