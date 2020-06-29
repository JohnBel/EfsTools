using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1292)]
    [Attributes(9)]
    public sealed class DcsPaTempCompIndex5
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}