using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2500)]
    [Attributes(9)]
    public sealed class FactoryData4
    {
        [FieldCount(128)]
        public byte[] Value { get; set; }
    }
}