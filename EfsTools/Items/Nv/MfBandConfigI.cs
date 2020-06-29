using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3373)]
    [Attributes(9)]
    public sealed class MfBandConfig
    {
        public ushort Value { get; set; }
    }
}