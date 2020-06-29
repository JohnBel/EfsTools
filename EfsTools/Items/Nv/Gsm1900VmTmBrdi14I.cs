using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2245)]
    [Attributes(9)]
    public sealed class Gsm1900VmTmBrdi14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}