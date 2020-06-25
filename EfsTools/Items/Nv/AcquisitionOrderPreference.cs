using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(848)]
    [Attributes(41)]
    public sealed class AcquisitionOrderPreference
    {
        public byte Nam { get; set; }


        public ushort Value { get; set; }
    }
}