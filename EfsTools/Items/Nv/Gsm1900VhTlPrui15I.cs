using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2383)]
    [Attributes(9)]
    public sealed class Gsm1900VhTlPrui15
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}