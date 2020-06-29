using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2365)]
    [Attributes(9)]
    public sealed class Gsm1900VmTlPrui15
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}