using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6530)]
    [Attributes(9)]
    public sealed class LteB13Antsel
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}