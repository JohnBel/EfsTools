using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class RfnvDataTxEptDpdV2Type
    {
        public ushort EptDpdIndex { get; set; }


        public QmslTxEptDpdV2AmamsType Amams { get; set; }


        public QmslTxEptDpdV2AmpmsType Ampms { get; set; }
    }
}