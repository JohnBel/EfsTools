using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2231)]
    [Attributes(9)]
    public sealed class GsmVmTmBrui12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}