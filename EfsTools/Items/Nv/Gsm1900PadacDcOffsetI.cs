using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5288)]
    [Attributes(9)]
    public sealed class Gsm1900PadacDcOffset
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}