using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class GsmTxLinearTxGainParamDataType
    {
        public ushort GsmLinearTxGainVal { get; set; }


        public ushort EdgeLinearTxGainVal { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] CharpredistEnvGain
        {
            get;
        }
    }
}