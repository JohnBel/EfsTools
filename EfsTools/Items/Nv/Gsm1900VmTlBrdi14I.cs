using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2191)]
    [Attributes(9)]
    public sealed class Gsm1900VmTlBrdi14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}