using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4372)]
    [Attributes(9)]
    public sealed class GsmRssiTempValues
    {
        [FieldCount(4)]
        public sbyte[] Value { get; set; }
    }
}