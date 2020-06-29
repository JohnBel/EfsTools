using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2312)]
    [Attributes(9)]
    public sealed class DcsVhThBrdi13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}