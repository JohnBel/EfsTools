using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6542)]
    [Attributes(9)]
    public sealed class LteB7RxDelay
    {
        public short Value { get; set; }
    }
}