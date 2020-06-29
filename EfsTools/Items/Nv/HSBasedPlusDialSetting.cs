using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4960)]
    [Attributes(9)]
    public sealed class HSBasedPlusDialSetting
    {
        public byte Value { get; set; }
    }
}