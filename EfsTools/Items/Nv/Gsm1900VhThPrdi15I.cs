using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2494)]
    [Attributes(9)]
    public sealed class Gsm1900VhThPrdi15
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}