using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024907", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB33TxLinMasterForApt1
    {
        [ElementsCount(64)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] TxLinMasterForApt1 { get; set; }
        
    }
}
