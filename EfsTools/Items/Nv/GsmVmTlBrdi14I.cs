using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2178)]
    [Attributes(9)]
    public sealed class GsmVmTlBrdi14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}