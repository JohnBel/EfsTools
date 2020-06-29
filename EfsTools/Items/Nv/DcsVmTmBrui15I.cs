using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2235)]
    [Attributes(9)]
    public sealed class DcsVmTmBrui15
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}