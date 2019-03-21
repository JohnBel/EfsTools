using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024827", true, 0xE1FF)]
    [Attributes(9)]
    public class Cdma1xBc15LteB2B25LteIm3DesenseI
    {
        [ElementsCount(10)]
        [ElementType("int16")]
        [Description("")]
        public short[] Cdma1xBc15LteB2B25LteIm3Desense { get; set; }
        
    }
}
