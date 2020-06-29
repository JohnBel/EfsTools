using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2477)]
    [Attributes(9)]
    public sealed class Gsm1900VmThPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}