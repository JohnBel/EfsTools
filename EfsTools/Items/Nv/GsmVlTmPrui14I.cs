using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2389)]
    [Attributes(9)]
    public sealed class GsmVlTmPrui14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}