using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(849)]
    [Attributes(41)]
    public sealed class NetworkSelectionModePreference
    {
        public byte Nam { get; set; }


        public ushort NetSelMode { get; set; }
    }
}