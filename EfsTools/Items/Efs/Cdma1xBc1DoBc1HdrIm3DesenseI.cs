using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025132", true, 0xE1FF)]
    [Attributes(9)]
    public class Cdma1xBc1DoBc1HdrIm3DesenseI
    {
        [ElementsCount(16)]
        [ElementType("int16")]
        [Description("")]
        public short[] Cdma1xBc1DoBc1HdrIm3Desense { get; set; }
        
    }
}
