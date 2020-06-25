using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class QmslTxLinV3FcompIndexType
    {
        public byte FcompType { get; set; }


        public ushort NumFcompUsed { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public ushort[] FcompIdx
        {
            get;
        }
    }
}