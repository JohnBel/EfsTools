using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2099)]
    [Attributes(9)]
    public sealed class GsmPrdi02
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}