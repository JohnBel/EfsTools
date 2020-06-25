using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/tdscdma/l1/rxd_params", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class RxdParams
    {
        [Required]
        public byte Version { get; set; }


        public byte RxdEnable { get; set; }


        public byte RxdRddsEnable { get; set; }


        public uint BlerHighThreshold { get; set; }


        public uint BlerLowThreshold { get; set; }


        public byte BlerAlpha { get; set; }


        public byte TimerTrans { get; set; }


        public ushort SirTargetThreshold { get; set; }


        public ushort SpecialBurstQualityThresholdLow { get; set; }


        public sbyte SirTargetSetPoint { get; set; }


        public byte TimeSpanSpecialBrstQual { get; set; }


        public ushort SpecialBurstQualityThresholdHigh { get; set; }


        public byte Reserved { get; set; }
    }
}