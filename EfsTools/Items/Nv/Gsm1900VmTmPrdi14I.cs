using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2423)]
    [Attributes(9)]
    public sealed class Gsm1900VmTmPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}