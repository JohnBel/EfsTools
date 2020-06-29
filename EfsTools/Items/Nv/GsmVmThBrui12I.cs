using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2285)]
    [Attributes(9)]
    public sealed class GsmVmThBrui12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}