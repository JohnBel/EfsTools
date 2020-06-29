using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6529)]
    [Attributes(9)]
    public sealed class LteB13HdetOffSpan
    {
        [FieldCount(2)]
        public ushort[] Value { get; set; }
    }
}