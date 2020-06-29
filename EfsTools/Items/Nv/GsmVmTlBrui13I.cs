using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2176)]
    [Attributes(9)]
    public sealed class GsmVmTlBrui13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}