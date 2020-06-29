using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(899)]
    [Attributes(9)]
    public sealed class JCdmaM512ModeSetting
    {
        public byte Value { get; set; }
    }
}