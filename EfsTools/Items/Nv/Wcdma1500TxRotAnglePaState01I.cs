using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6982)]
    [Attributes(9)]
    public sealed class Wcdma1500TxRotAnglePaState01
    {
        public ushort Value { get; set; }
    }
}