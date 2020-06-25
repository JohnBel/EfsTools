using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3721)]
    [Attributes(9)]
    public sealed class Wcdma900PaCompensateDownR3
    {
        public short Value { get; set; }
    }
}