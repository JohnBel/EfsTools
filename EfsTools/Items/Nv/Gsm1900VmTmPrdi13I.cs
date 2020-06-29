using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2424)]
    [Attributes(9)]
    public sealed class Gsm1900VmTmPrdi13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}