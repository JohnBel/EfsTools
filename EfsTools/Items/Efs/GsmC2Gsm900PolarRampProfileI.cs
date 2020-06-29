using System;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025121", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC2Gsm900PolarRampProfile
    {
        public GsmTxPolarRampProfileDataType PolarParampLut { get; set; }
    }
}