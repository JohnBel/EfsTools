using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2223)]
    [Attributes(9)]
    public sealed class Gsm1900VlTmBrui15
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}