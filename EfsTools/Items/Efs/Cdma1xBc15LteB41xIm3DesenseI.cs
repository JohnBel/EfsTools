using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025135", true, 0xE1FF)]
    [Attributes(9)]
    public class Cdma1xBc15LteB41xIm3Desense
    {
        [ElementsCount(16)]
        [ElementType("int16")]
        [Description("")]
        public short[] Cdma1xBc15LteBc41xIm3Desense { get; set; }
        
    }
}
