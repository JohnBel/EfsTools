using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6052)]
    [Attributes(9)]
    public sealed class Wcdma800HsSwitchpointsShift
    {
        [FieldCount(2)]
        public sbyte[] Value { get; set; }
    }
}