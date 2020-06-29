using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2348)]
    [Attributes(9)]
    public sealed class Gsm1900VlTlPrui14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}