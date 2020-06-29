using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2158)]
    [Attributes(9)]
    public sealed class GsmVlTlBrui13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}