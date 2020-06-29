using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2438)]
    [Attributes(9)]
    public sealed class Gsm1900VhTmPrui14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}