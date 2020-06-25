using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class QmslRxSpurTableNvType
    {
        public uint AbsFreqHz { get; set; }


        public byte NotchSetting { get; set; }
    }
}