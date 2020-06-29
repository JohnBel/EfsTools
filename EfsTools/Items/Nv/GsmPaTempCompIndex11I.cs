using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1284)]
    [Attributes(9)]
    public sealed class GsmPaTempCompIndex11
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}