using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6999)]
    [Attributes(9)]
    public sealed class Wcdma1500MaxPwrBackoffVolt1
    {
        [FieldCount(4)]
        public short[] Value { get; set; }
    }
}