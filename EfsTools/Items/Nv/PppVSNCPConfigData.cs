using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6247)]
    [Attributes(9)]
    public sealed class PppVsncpConfigData
    {
        public uint TermTimeout { get; set; }


        public uint AckTimeout { get; set; }


        public ushort RegTry { get; set; }


        public ushort TermTry { get; set; }
    }
}