using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(95)]
    [Attributes(9)]
    public sealed class FmRssi
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}