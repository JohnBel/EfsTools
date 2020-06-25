using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7040)]
    [Attributes(9)]
    public sealed class Wcdma1500RxfIciQCoef45
    {
        public uint Value { get; set; }
    }
}