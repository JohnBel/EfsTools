using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2266)]
    [Attributes(9)]
    public sealed class GsmVlThBrui13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}