using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2480)]
    [Attributes(9)]
    public sealed class GsmVhThPrui13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}