using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class GsmTxSmpsPdmDataType
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] CalSmpsPdmTbl
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public ushort[] GsmSmpsPdmTbl
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public ushort[] EdgeSmpsPdmTbl
        {
            get;
        }
    }
}