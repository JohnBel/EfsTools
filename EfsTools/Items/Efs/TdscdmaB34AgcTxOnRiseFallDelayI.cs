using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022628", true, 0xE1FF)]
    [Attributes(9)]
    public class TdscdmaB34AgcTxOnRiseFallDelayI
    {
        [ElementsCount(2)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
