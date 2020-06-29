using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025006", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC0Gsm1800EnvGain
    {
        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF1 { get; set; }

        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF2 { get; set; }

        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF3 { get; set; }
    }
}