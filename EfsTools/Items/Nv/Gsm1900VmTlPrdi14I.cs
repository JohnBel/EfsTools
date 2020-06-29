using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2369)]
    [Attributes(9)]
    public sealed class Gsm1900VmTlPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}