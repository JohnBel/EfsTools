using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3723)]
    [Attributes(9)]
    public sealed class Wcdma900TxRotAnglePaState01
    {
        public ushort Value { get; set; }
    }
}