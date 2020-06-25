using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3629)]
    [Attributes(9)]
    public sealed class DtmMultislotClass
    {
        public byte Value { get; set; }
    }
}