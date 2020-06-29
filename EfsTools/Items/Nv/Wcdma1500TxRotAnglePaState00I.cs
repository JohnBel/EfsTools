using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6981)]
    [Attributes(9)]
    public sealed class Wcdma1500TxRotAnglePaState00
    {
        public ushort Value { get; set; }
    }
}