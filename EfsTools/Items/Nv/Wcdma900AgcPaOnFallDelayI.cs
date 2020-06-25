using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3698)]
    [Attributes(9)]
    public sealed class Wcdma900AgcPaOnFallDelay
    {
        public ushort Value { get; set; }
    }
}