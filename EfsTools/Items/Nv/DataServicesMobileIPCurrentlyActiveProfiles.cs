using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(464)]
    [Attributes(13)]
    public sealed class DataServicesMobileIpCurrentlyActiveProfiles
    {
        public byte Value { get; set; }
    }
}