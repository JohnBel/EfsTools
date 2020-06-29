using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3152)]
    [Attributes(9)]
    public sealed class DcsRtr6250Rsb
    {
        [FieldCount(8)]
        public ushort[] Value { get; set; }
    }
}