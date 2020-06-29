using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1325)]
    [Attributes(9)]
    public sealed class Gsm850PaTempCompIndex13
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}