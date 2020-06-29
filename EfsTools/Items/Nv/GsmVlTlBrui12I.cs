using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2159)]
    [Attributes(9)]
    public sealed class GsmVlTlBrui12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}