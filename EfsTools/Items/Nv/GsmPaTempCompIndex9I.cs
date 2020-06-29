using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1282)]
    [Attributes(9)]
    public sealed class GsmPaTempCompIndex9
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}