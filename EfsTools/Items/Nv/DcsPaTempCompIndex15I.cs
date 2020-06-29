using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(935)]
    [Attributes(9)]
    public sealed class DcsPaTempCompIndex15
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}