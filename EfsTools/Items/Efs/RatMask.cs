using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Subscription]
    [EfsFile("/policyman/rat_mask", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class RatMask

    {
        public RatMask()
        {
            Value = new byte[56];
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
        public byte[] Value { get; set; }
    }
}