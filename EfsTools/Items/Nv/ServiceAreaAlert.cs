using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(69)]
    [Attributes(9)]
    public sealed class ServiceAreaAlert
    {
        public byte Value { get; set; }
    }
}