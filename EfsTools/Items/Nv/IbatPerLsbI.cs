using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(364)]
    [Attributes(9)]
    public sealed class IbatPerLsb
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}