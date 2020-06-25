using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6874)]
    [Attributes(25)]
    public sealed class Asid1Data
    {
        public byte SessionType { get; set; }


        public sbyte Reserved { get; set; }
    }
}