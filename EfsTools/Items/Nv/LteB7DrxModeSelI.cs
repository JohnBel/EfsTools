using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6751)]
    [Attributes(9)]
    public sealed class LteB7DrxModeSel
    {
        [FieldCount(3)]
        public byte[] Value { get; set; }
    }
}