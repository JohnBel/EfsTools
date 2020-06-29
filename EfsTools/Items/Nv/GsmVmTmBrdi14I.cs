using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2232)]
    [Attributes(9)]
    public sealed class GsmVmTmBrdi14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}