using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7033)]
    [Attributes(9)]
    public sealed class Wcdma1500RxfIciICoef67
    {
        public uint Value { get; set; }
    }
}