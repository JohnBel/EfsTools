using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class RfnvDataTxEtDpdType
    {
        public ushort EtDpdIndex { get; set; }


        public QmslTxEtDpdAmamsType Amams { get; set; }


        public QmslTxEtDpdAmpmsType Ampms { get; set; }


        public QmslTxEtDpdEpdtsType Epdts { get; set; }
    }
}