using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3501)]
    [Attributes(9)]
    public sealed class GsmGainrange5Switchpoints
    {
        [FieldCount(2)]
        public sbyte[] Value { get; set; }
    }
}