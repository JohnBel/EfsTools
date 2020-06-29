using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6907)]
    [Attributes(9)]
    public sealed class UimHwSimConfig
    {
        public ushort Value { get; set; }
    }
}