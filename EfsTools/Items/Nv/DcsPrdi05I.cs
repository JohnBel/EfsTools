using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2127)]
    [Attributes(9)]
    public sealed class DcsPrdi05
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}