using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6545)]
    [Attributes(9)]
    public sealed class LteB7ImLevel
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}