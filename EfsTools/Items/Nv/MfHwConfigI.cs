using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3372)]
    [Attributes(9)]
    public sealed class MfHwConfig
    {
        public ushort Value { get; set; }
    }
}