using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024914", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB33Db10SarBackOffLimit
    {
        [ElementsCount(8)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] LteDb10SarBackOffLimit { get; set; }
        
    }
}
