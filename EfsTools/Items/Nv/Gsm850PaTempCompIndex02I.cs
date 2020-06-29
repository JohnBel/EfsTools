using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1314)]
    [Attributes(9)]
    public sealed class Gsm850PaTempCompIndex02
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}