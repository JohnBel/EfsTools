using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5103)]
    [Attributes(9)]
    public sealed class Wcdma1800LnaPhaseCtl
    {
        [FieldCount(6)]
        public ushort[] Value { get; set; }
    }
}