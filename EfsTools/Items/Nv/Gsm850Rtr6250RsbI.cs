using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3153)]
    [Attributes(9)]
    public sealed class Gsm850Rtr6250Rsb
    {
        [FieldCount(8)]
        public ushort[] Value { get; set; }
    }
}