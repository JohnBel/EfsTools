using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class EptDpdStruct
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public int[] Am
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public int[] Pm
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] PmShift
        {
            get;
        }


        public sbyte Status { get; set; }
    }
}