using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(442)]
    [Attributes(45)]
    public sealed class RoamingPreference
    {
        public byte Nam { get; set; }


        public ushort Roam { get; set; }
    }
}