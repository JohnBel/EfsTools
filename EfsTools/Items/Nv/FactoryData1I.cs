using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2497)]
    [Attributes(9)]
    public sealed class FactoryData1
    {
        [FieldCount(128)]
        public byte[] Value { get; set; }
    }
}