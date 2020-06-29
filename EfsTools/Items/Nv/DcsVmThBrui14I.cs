using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2290)]
    [Attributes(9)]
    public sealed class DcsVmThBrui14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}