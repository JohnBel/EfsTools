using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2412)]
    [Attributes(9)]
    public sealed class GsmVmTmPrdi12
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}