using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2478)]
    [Attributes(9)]
    public sealed class Gsm1900VmThPrdi13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}