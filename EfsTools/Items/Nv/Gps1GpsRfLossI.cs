using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(449)]
    [Attributes(9)]
    public sealed class Gps1GpsRfLoss
    {
        public byte Value { get; set; }
    }
}