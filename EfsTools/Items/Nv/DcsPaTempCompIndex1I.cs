using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1288)]
    [Attributes(9)]
    public sealed class DcsPaTempCompIndex1
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}