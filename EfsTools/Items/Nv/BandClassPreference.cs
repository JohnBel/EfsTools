using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(441)]
    [Attributes(41)]
    public sealed class BandClassPreference
    {
        public byte Nam { get; set; }


        public short Band { get; set; }
    }
}