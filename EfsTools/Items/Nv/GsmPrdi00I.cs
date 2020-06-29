using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2097)]
    [Attributes(9)]
    public sealed class GsmPrdi00
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}