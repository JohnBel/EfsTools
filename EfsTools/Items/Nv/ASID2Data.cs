using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6875)]
    [Attributes(25)]
    public sealed class Asid2Data
    {
        public byte SessionType { get; set; }


        public sbyte Reserved { get; set; }
    }
}