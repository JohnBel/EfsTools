using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025042", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC2Gsm1800AmamTempComp
    {
        [ElementsCount(16)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] AmamTempComp { get; set; }
        
    }
}
