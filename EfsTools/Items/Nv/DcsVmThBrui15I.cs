using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2289)]
    [Attributes(9)]
    public sealed class DcsVmThBrui15
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}