using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1324)]
    [Attributes(9)]
    public sealed class Gsm850PaTempCompIndex12
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}