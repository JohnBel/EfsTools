using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(177)]
    [Attributes(45)]
    public sealed class Imsi11_12
    {
        public byte Nam { get; set; }


        public byte Value { get; set; }
    }
}