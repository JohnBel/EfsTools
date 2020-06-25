using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2909)]
    [Attributes(9)]
    public sealed class Wcdma1800TxRotAnglePaState01
    {
        public ushort Value { get; set; }
    }
}