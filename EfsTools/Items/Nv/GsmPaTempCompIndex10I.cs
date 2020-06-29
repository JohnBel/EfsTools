using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1283)]
    [Attributes(9)]
    public sealed class GsmPaTempCompIndex10
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}