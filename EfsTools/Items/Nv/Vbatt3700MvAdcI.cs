using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(811)]
    [Attributes(9)]
    public sealed class Vbatt3700MvAdc
    {
        public ushort Value { get; set; }
    }
}