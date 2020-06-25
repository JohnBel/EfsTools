using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6429)]
    [Attributes(41)]
    public sealed class HdrIs683AScanList
    {
        public byte Nam { get; set; }


        public byte Band { get; set; }


        public ushort Chan { get; set; }
    }
}