using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6050)]
    [Attributes(9)]
    public sealed class Wcdma1800HsSwitchpointsShift
    {
        [FieldCount(2)]
        public sbyte[] Value { get; set; }
    }
}