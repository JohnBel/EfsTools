using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2427)]
    [Attributes(9)]
    public sealed class GsmVhTmPrui12
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}