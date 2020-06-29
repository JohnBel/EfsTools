using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(595)]
    [Attributes(9)]
    public sealed class PcsLna3Offset
    {
        public short Value { get; set; }
    }
}