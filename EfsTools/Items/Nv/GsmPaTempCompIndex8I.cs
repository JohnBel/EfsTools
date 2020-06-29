using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1281)]
    [Attributes(9)]
    public sealed class GsmPaTempCompIndex8
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}