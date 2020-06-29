using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2180)]
    [Attributes(9)]
    public sealed class GsmVmTlBrdi12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}