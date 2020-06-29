using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6494)]
    [Attributes(9)]
    public sealed class LteB13ImLevel
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}