using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7050)]
    [Attributes(9)]
    public sealed class Wcdma1500HsR2Fall
    {
        public short Value { get; set; }
    }
}