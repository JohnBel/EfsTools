using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2267)]
    [Attributes(9)]
    public sealed class GsmVlThBrui12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}