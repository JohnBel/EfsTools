using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2393)]
    [Attributes(9)]
    public sealed class GsmVlTmPrdi13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}