using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslRxSpurTableNvType
    {
        public uint AbsFreqHz { get; set; }


        public byte NotchSetting { get; set; }
    }
}