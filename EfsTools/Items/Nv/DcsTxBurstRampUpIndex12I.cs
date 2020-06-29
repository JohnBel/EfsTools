using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(782)]
    [Attributes(9)]
    public sealed class DcsTxBurstRampUpIndex12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}