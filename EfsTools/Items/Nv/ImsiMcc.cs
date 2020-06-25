using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(176)]
    [Attributes(45)]
    public sealed class ImsiMcc
    {
        public byte Nam { get; set; }


        public ushort Value { get; set; }
    }
}