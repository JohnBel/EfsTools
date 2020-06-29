using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1316)]
    [Attributes(9)]
    public sealed class Gsm850PaTempCompIndex04
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}