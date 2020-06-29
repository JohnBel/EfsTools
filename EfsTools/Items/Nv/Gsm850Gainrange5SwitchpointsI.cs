using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3507)]
    [Attributes(9)]
    public sealed class Gsm850Gainrange5Switchpoints
    {
        [FieldCount(2)]
        public sbyte[] Value { get; set; }
    }
}