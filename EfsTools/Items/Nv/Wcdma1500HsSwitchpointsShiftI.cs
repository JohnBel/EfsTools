using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7065)]
    [Attributes(9)]
    public sealed class Wcdma1500HsSwitchpointsShift
    {
        [FieldCount(2)]
        public sbyte[] Value { get; set; }
    }
}