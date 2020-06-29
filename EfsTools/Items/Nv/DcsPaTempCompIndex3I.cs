using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1290)]
    [Attributes(9)]
    public sealed class DcsPaTempCompIndex3
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}