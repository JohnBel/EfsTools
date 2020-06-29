using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2170)]
    [Attributes(9)]
    public sealed class Gsm1900VlTlBrui14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}