using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2311)]
    [Attributes(9)]
    public sealed class DcsVhThBrdi14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}