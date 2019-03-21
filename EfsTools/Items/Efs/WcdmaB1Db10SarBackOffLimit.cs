using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021321", true, 0xE1FF)]
    [Attributes(9)]
    public class WcdmaB1Db10SarBackOffLimit
    {
        [ElementsCount(8)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
