using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5463)]
    [Attributes(9)]
    public sealed class Wcdma1800ExpHdetVsAgcV2
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}