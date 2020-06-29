using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2226)]
    [Attributes(9)]
    public sealed class Gsm1900VlTmBrdi15
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}