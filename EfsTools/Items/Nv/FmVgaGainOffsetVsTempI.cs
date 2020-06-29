using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(698)]
    [Attributes(9)]
    public sealed class FmVgaGainOffsetVsTemp
    {
        [FieldCount(8)]
        public short[] Value { get; set; }
    }
}