using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2095)]
    [Attributes(9)]
    public sealed class GsmPrui09
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}