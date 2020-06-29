using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6687)]
    [Attributes(9)]
    public sealed class LteB40C1Antsel
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}