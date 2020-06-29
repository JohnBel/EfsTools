using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1322)]
    [Attributes(9)]
    public sealed class Gsm850PaTempCompIndex10
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}