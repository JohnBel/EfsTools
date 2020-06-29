using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2198)]
    [Attributes(9)]
    public sealed class GsmVhTlBrdi12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}