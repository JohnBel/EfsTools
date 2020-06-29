using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2287)]
    [Attributes(9)]
    public sealed class GsmVmThBrdi13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}