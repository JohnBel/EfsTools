using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4368)]
    [Attributes(9)]
    public sealed class Gsm850PaTempCompMaxPwr
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}