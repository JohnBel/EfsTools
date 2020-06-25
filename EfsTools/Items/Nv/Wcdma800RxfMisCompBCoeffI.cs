using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5909)]
    [Attributes(9)]
    public sealed class Wcdma800RxfMisCompBCoeff
    {
        public short Value { get; set; }
    }
}