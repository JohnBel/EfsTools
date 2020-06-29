using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2482)]
    [Attributes(9)]
    public sealed class GsmVhThPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}