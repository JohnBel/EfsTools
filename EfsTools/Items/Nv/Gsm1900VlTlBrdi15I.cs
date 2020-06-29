using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2172)]
    [Attributes(9)]
    public sealed class Gsm1900VlTlBrdi15
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}