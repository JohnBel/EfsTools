using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2131)]
    [Attributes(9)]
    public sealed class DcsPrdi09
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}