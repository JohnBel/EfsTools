using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023726", true, 0xE1FF)]
    [Attributes(9)]
    public class LteGnssBlankingRiseFallDelta
    {
        [ElementsCount(2)]
        [ElementType("int16")]
        [Description("")]
        public short[] RiseDelay { get; set; }
        
    }
}
