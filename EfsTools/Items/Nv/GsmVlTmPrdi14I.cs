using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2392)]
    [Attributes(9)]
    public sealed class GsmVlTmPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}