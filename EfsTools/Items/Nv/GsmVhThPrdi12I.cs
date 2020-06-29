using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2484)]
    [Attributes(9)]
    public sealed class GsmVhThPrdi12
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}