using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2291)]
    [Attributes(9)]
    public sealed class DcsVmThBrui13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}