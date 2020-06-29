using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2429)]
    [Attributes(9)]
    public sealed class GsmVhTmPrdi13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}