using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(854)]
    [Attributes(41)]
    public sealed class DataServicesMobileIpDmuPkoId
    {
        public byte Index { get; set; }


        public byte PkoId { get; set; }
    }
}