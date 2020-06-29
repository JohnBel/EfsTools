using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6750)]
    [Attributes(9)]
    public sealed class LteB13DrxModeSel
    {
        [FieldCount(3)]
        public byte[] Value { get; set; }
    }
}