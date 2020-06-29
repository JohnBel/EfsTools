using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1298)]
    [Attributes(9)]
    public sealed class DcsPaTempCompIndex11
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}