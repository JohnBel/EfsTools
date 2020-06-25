using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1193)]
    [Attributes(13)]
    public sealed class DataServicesMobileIpQcHanddown
    {
        public byte Value { get; set; }
    }
}