using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1304)]
    [Attributes(9)]
    public sealed class DcsPaTempCompInt8Index15
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}