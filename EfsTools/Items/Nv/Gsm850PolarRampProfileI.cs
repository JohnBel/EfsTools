using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3511)]
    [Attributes(9)]
    public sealed class Gsm850PolarRampProfile
    {
        [FieldCount(60)]
        public ushort[] Value { get; set; }
    }
}