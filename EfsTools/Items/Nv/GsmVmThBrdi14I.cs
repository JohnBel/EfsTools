using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2286)]
    [Attributes(9)]
    public sealed class GsmVmThBrdi14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}