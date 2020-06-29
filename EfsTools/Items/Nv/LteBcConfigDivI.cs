using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6829)]
    [Attributes(9)]
    public sealed class LteBcConfigDiv
    {
        [FieldCount(2)]
        public ulong[] Value { get; set; }
    }
}