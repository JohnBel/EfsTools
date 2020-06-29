using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2098)]
    [Attributes(9)]
    public sealed class GsmPrdi01
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}