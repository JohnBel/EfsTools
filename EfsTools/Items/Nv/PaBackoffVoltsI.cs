using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(492)]
    [Attributes(9)]
    public sealed class PaBackoffVolts
    {
        [FieldCount(3)]
        public byte[] Value { get; set; }
    }
}