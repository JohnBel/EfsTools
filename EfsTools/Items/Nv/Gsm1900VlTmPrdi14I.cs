using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2405)]
    [Attributes(9)]
    public sealed class Gsm1900VlTmPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}