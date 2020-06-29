using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6509)]
    [Attributes(9)]
    public sealed class LteB13PaRangeMap
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}