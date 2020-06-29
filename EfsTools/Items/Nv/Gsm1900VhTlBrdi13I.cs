using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2210)]
    [Attributes(9)]
    public sealed class Gsm1900VhTlBrdi13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}