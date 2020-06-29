using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5462)]
    [Attributes(9)]
    public sealed class WcdmaBc4ExpHdetVsAgcV2
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}