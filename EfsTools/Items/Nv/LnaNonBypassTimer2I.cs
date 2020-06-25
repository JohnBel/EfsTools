using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(841)]
    [Attributes(9)]
    public sealed class LnaNonBypassTimer2
    {
        public ushort Value { get; set; }
    }
}