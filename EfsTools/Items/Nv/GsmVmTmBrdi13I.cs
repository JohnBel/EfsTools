using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2233)]
    [Attributes(9)]
    public sealed class GsmVmTmBrdi13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}