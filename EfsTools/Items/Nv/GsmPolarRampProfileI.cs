using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3353)]
    [Attributes(9)]
    public sealed class GsmPolarRampProfile
    {
        [FieldCount(60)]
        public ushort[] Value { get; set; }
    }
}