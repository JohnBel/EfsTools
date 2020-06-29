using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2391)]
    [Attributes(9)]
    public sealed class GsmVlTmPrui12
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}