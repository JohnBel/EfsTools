using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1291)]
    [Attributes(9)]
    public sealed class DcsPaTempCompIndex4
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}