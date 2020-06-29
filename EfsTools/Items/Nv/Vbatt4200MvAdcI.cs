using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(812)]
    [Attributes(9)]
    public sealed class Vbatt4200MvAdc
    {
        public ushort Value { get; set; }
    }
}