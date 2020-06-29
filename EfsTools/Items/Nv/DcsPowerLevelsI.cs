using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3060)]
    [Attributes(9)]
    public sealed class DcsPowerLevels
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}