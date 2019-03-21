using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024829", true, 0xE1FF)]
    [Attributes(9)]
    public class Cdma1xBc1DoBc15GnssIm3DesenseI
    {
        [ElementsCount(10)]
        [ElementType("int16")]
        [Description("")]
        public short[] Cdma1xBc1DoBc15Im3Desense { get; set; }
        
    }
}
