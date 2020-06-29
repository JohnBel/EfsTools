using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2292)]
    [Attributes(9)]
    public sealed class DcsVmThBrdi15
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}