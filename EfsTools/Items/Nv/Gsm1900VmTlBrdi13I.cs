using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2192)]
    [Attributes(9)]
    public sealed class Gsm1900VmTlBrdi13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}