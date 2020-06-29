using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6752)]
    [Attributes(9)]
    public sealed class LteB17DrxModeSel
    {
        [FieldCount(3)]
        public byte[] Value { get; set; }
    }
}