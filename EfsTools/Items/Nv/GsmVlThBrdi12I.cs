using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2270)]
    [Attributes(9)]
    public sealed class GsmVlThBrdi12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}