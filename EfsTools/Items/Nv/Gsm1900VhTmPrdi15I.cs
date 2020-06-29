using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2440)]
    [Attributes(9)]
    public sealed class Gsm1900VhTmPrdi15
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}