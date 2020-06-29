using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2894)]
    [Attributes(9)]
    public sealed class Wcdma1800ExpHdetVsAgc
    {
        [FieldCount(16)]
        public byte[] Value { get; set; }
    }
}