using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024909", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB33TxLinMasterForApt3
    {
        [ElementsCount(64)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] TxLinMasterForApt3 { get; set; }
        
    }
}
