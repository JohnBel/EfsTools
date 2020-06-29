using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2498)]
    [Attributes(9)]
    public sealed class FactoryData2
    {
        [FieldCount(128)]
        public byte[] Value { get; set; }
    }
}