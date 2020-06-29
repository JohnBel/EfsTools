using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1321)]
    [Attributes(9)]
    public sealed class Gsm850PaTempCompIndex09
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}