using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(490)]
    [Attributes(9)]
    public sealed class PwrBackoffVsVoltMed
    {
        [FieldCount(20)]
        public byte[] Value { get; set; }
    }
}