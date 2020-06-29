using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2089)]
    [Attributes(9)]
    public sealed class GsmPrui03
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}