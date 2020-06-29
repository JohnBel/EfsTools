using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2193)]
    [Attributes(9)]
    public sealed class GsmVhTlBrui14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}