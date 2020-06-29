using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2209)]
    [Attributes(9)]
    public sealed class Gsm1900VhTlBrdi14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}