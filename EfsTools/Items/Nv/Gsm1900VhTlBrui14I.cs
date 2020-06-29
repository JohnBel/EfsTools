using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2206)]
    [Attributes(9)]
    public sealed class Gsm1900VhTlBrui14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}