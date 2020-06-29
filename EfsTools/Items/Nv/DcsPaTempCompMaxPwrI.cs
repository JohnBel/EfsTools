using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4370)]
    [Attributes(9)]
    public sealed class DcsPaTempCompMaxPwr
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}