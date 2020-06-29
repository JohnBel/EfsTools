using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2428)]
    [Attributes(9)]
    public sealed class GsmVhTmPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}