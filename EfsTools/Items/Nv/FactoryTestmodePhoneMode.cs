using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(453)]
    [Attributes(9)]
    public sealed class FactoryTestmodePhoneMode
    {
        public byte Value { get; set; }
    }
}