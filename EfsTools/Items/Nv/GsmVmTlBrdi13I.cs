using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2179)]
    [Attributes(9)]
    public sealed class GsmVmTlBrdi13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}