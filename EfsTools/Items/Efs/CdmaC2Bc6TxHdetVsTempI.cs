using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024767", true, 0xE1FF)]
    [Attributes(9)]
    public class CdmaC2Bc6TxHdetVsTempI
    {
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] HdetVsTemp { get; set; }
        
    }
}
