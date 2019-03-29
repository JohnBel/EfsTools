using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024870", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB33TxDigitalGainComp
    {
        [ElementsCount(16)]
        [ElementType("int16")]
        [Description("")]
        public short[] LteTxDigitalGainComp { get; set; }
        
    }
}
