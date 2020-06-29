using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2410)]
    [Attributes(9)]
    public sealed class GsmVmTmPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}