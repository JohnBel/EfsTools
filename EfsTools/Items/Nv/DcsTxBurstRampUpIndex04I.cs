using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(774)]
    [Attributes(9)]
    public sealed class DcsTxBurstRampUpIndex04
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}