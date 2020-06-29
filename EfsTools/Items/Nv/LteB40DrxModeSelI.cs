using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6753)]
    [Attributes(9)]
    public sealed class LteB40DrxModeSel
    {
        [FieldCount(3)]
        public byte[] Value { get; set; }
    }
}