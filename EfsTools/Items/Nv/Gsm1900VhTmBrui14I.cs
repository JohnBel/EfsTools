using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2260)]
    [Attributes(9)]
    public sealed class Gsm1900VhTmBrui14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}