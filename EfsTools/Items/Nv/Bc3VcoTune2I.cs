using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3239)]
    [Attributes(9)]
    public sealed class Bc3VcoTune2
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        public byte[] Value
        {
            get;
        }
    }
}