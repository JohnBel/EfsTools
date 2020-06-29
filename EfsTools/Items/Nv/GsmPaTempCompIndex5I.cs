using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1278)]
    [Attributes(9)]
    public sealed class GsmPaTempCompIndex5
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}