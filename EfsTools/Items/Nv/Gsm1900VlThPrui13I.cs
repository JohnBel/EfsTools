using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2457)]
    [Attributes(9)]
    public sealed class Gsm1900VlThPrui13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}