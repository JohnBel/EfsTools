using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2394)]
    [Attributes(9)]
    public sealed class GsmVlTmPrdi12
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}