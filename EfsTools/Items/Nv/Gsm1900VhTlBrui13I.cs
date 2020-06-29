using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2207)]
    [Attributes(9)]
    public sealed class Gsm1900VhTlBrui13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}