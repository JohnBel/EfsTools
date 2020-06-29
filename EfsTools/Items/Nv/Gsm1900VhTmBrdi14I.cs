using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2263)]
    [Attributes(9)]
    public sealed class Gsm1900VhTmBrdi14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}