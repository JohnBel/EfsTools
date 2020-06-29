using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2370)]
    [Attributes(9)]
    public sealed class Gsm1900VmTlPrdi13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}