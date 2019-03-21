using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024903", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB33PaSmpsOdrive
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort SmpsOdrive { get; set; }
        
    }
}
