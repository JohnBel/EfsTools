using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022982", true, 0xE1FF)]
    [Attributes(9)]
    public class MsmSelfCalI
    {
        [ElementsCount(16384)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] Reserved { get; set; }
        
    }
}
