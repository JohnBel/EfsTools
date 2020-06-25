using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(132)]
    [Attributes(9)]
    public sealed class CdmaTxLinMasterOff0
    {
        public ushort Value { get; set; }
    }
}