using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024913", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB33TxGainIndexForApt3I
    {
        [ElementsCount(64)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] TxGainIndexForApt3 { get; set; }
        
    }
}
