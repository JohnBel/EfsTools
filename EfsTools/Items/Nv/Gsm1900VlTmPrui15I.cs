using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2401)]
    [Attributes(9)]
    public sealed class Gsm1900VlTmPrui15
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}