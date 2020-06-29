using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2177)]
    [Attributes(9)]
    public sealed class GsmVmTlBrui12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}