using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class QmslTxLinV3DpdInfoType
    {
        public byte DpdTypeUsed { get; set; }


        public ushort NumDpdUsed { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public ushort[] DpdIdx
        {
            get;
        }
    }
}