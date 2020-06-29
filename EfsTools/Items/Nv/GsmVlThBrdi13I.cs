using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2269)]
    [Attributes(9)]
    public sealed class GsmVlThBrdi13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}