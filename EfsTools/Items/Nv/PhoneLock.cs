using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(81)]
    [Attributes(9)]
    public sealed class PhoneLock
    {
        public byte Value { get; set; }
    }
}