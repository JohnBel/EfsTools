using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Ignore]
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2826)]
    [Attributes(9)]
    public sealed class Wcdma1800RxAgcMin3
    {
        public byte Field1 { get; set; }


        public byte Field2 { get; set; }
    }
}