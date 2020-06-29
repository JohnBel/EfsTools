using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3059)]
    [Attributes(9)]
    public sealed class GsmPowerLevels
    {
        [FieldCount(15)]
        public short[] Value { get; set; }
    }
}