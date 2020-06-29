using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2402)]
    [Attributes(9)]
    public sealed class Gsm1900VlTmPrui14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}