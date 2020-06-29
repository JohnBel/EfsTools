using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2195)]
    [Attributes(9)]
    public sealed class GsmVhTlBrui12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}