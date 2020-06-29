using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5287)]
    [Attributes(9)]
    public sealed class Gsm1800PadacDcOffset
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}