using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020000", true, 0xE1FF)]
    [Attributes(9)]
    public class Cdma1xBc0DoBc0SarI
    {
        [ElementsCount(10)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
