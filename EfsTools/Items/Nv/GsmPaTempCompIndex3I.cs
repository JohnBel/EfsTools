using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1276)]
    [Attributes(9)]
    public sealed class GsmPaTempCompIndex3
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}