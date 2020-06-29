using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2368)]
    [Attributes(9)]
    public sealed class Gsm1900VmTlPrdi15
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}