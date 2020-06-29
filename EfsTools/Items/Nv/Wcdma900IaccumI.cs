using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4171)]
    [Attributes(9)]
    public sealed class Wcdma900Iaccum
    {
        [FieldCount(6)]
        public ushort[] Value { get; set; }
    }
}