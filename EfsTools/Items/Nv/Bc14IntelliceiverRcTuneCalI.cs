using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6289)]
    [Attributes(9)]
    public sealed class Bc14IntelliceiverRcTuneCal
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ushort[] Value
        {
            get;
        }
    }
}