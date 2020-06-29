using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6831)]
    [Attributes(9)]
    public sealed class VoipCancelRetryTimer
    {
        public byte Value { get; set; }
    }
}