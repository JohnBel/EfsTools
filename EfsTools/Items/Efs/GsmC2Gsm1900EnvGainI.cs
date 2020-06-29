using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025011", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC2Gsm1900EnvGain
    {
        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF1 { get; set; }

        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF2 { get; set; }

        [FieldCount(32)]
        public ushort[] EnvGainFreqRgiF3 { get; set; }
    }
}