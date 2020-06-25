using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class GsmTxSarBackoffDataType
    {
        public short SarGmsk { get; set; }


        public short Sar8psk { get; set; }
    }
}