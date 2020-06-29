using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7123)]
    [Attributes(9)]
    public sealed class Wcdma1500ExpHdetVsAgcV2
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}