using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class GsmTxTempCompDataType
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public short[] TempCompPclPwrScaling
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public ushort[] HotTempCompPclPwrOffsetGsmk
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public ushort[] ColdTempCompPclPwrOffsetGsmk
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public ushort[] HotTempCompPclPwrOffset8psk
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public ushort[] ColdTempCompPclPwrOffset8psk
        {
            get;
        }
    }
}