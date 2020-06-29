using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(365)]
    [Attributes(9)]
    public sealed class Iext
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}