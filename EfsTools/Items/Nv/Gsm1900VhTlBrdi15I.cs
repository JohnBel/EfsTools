using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2208)]
    [Attributes(9)]
    public sealed class Gsm1900VhTlBrdi15
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}