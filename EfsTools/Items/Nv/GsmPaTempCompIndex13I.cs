using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1286)]
    [Attributes(9)]
    public sealed class GsmPaTempCompIndex13
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}