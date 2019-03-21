using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025478", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB28Db10SarBackOffLimitI
    {
        [ElementsCount(8)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] LteDb10SarBackOffLimit { get; set; }
        
    }
}
