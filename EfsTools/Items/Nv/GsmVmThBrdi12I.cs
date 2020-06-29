using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2288)]
    [Attributes(9)]
    public sealed class GsmVmThBrdi12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}