using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1171)]
    [Attributes(9)]
    public sealed class Wcdma1900RxAgcMax
    {
        public short Value { get; set; }
    }
}