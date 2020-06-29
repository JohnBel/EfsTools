using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3061)]
    [Attributes(9)]
    public sealed class Gsm850PowerLevels
    {
        [FieldCount(15)]
        public short[] Value { get; set; }
    }
}