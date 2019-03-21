using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022558", true, 0xE1FF)]
    [Attributes(9)]
    public class C1WcdmaB5RxfIciCalDataCar1I
    {
        [ElementsCount(17)]
        [ElementType("uint32")]
        [Description("")]
        public uint[] Value { get; set; }
        
    }
}
