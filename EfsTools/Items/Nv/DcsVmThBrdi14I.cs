using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2293)]
    [Attributes(9)]
    public sealed class DcsVmThBrdi14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}