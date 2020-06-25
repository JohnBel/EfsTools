using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class GsmTxPolarRampProfileDataType
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
        public ushort[] RampUp
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
        public ushort[] RampDown
        {
            get;
        }
    }
}