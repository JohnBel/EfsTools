using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(405)]
    [Attributes(9)]
    public sealed class Is2000CaiRadioConfigurationRcPreference
    {
        public ushort Value { get; set; }
    }
}