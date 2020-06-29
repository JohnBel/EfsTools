using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2411)]
    [Attributes(9)]
    public sealed class GsmVmTmPrdi13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}