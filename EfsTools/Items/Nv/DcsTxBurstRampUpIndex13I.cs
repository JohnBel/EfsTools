using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(783)]
    [Attributes(9)]
    public sealed class DcsTxBurstRampUpIndex13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}