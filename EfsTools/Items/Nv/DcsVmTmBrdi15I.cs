using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2238)]
    [Attributes(9)]
    public sealed class DcsVmTmBrdi15
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}