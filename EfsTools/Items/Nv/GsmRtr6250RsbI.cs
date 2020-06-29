using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3151)]
    [Attributes(9)]
    public sealed class GsmRtr6250Rsb
    {
        [FieldCount(8)]
        public ushort[] Value { get; set; }
    }
}