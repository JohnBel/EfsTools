using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4038)]
    [Attributes(9)]
    public sealed class WcdmaBc4ExpHdetVsAgc
    {
        [FieldCount(16)]
        public byte[] Value { get; set; }
    }
}