using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(494)]
    [Attributes(41)]
    public sealed class DataServicesMobileIpMnHomeAgentTimebaseDifference
    {
        public byte Index { get; set; }


        public uint TimeDelta { get; set; }
    }
}