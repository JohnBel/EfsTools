using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2408)]
    [Attributes(9)]
    public sealed class GsmVmTmPrui13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}