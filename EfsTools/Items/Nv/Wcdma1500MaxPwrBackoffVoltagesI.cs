using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6998)]
    [Attributes(9)]
    public sealed class Wcdma1500MaxPwrBackoffVoltages
    {
        [FieldCount(3)]
        public byte[] Value { get; set; }
    }
}