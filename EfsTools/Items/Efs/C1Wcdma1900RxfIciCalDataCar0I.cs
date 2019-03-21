using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020473", true, 0xE1FF)]
    [Attributes(9)]
    public class C1Wcdma1900RxfIciCalDataCar0I
    {
        [ElementsCount(17)]
        [ElementType("uint32")]
        [Description("")]
        public uint[] Value { get; set; }
        
    }
}
