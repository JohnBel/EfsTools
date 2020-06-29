using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(725)]
    [Attributes(9)]
    public sealed class DcsCalArfcn
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}