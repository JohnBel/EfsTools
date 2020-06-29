using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2236)]
    [Attributes(9)]
    public sealed class DcsVmTmBrui14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}