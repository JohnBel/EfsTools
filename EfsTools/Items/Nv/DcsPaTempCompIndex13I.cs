using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1300)]
    [Attributes(9)]
    public sealed class DcsPaTempCompIndex13
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}