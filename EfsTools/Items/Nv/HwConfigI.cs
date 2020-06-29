using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(198)]
    [Attributes(9)]
    public sealed class HwConfig
    {
        public uint Value { get; set; }
    }
}