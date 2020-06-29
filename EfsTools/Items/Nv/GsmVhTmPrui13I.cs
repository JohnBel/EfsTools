using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2426)]
    [Attributes(9)]
    public sealed class GsmVhTmPrui13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}