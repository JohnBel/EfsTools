using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2103)]
    [Attributes(9)]
    public sealed class GsmPrdi06
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}