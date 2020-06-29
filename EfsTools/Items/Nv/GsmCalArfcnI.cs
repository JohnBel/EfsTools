using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(724)]
    [Attributes(9)]
    public sealed class GsmCalArfcn
    {
        [FieldCount(8)]
        public ushort[] Value { get; set; }
    }
}