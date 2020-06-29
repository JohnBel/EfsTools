using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2093)]
    [Attributes(9)]
    public sealed class GsmPrui07
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}