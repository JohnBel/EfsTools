using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2194)]
    [Attributes(9)]
    public sealed class GsmVhTlBrui13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}