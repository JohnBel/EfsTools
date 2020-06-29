using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1273)]
    [Attributes(9)]
    public sealed class GsmPaTempCompIndex0
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}