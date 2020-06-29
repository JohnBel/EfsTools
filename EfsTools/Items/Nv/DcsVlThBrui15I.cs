using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2271)]
    [Attributes(9)]
    public sealed class DcsVlThBrui15
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}