using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024858", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB33AgcTxOnRiseFallDelay
    {
        [ElementsCount(2)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] AgcTxOnRiseFallDelayType { get; set; }
        
    }
}
