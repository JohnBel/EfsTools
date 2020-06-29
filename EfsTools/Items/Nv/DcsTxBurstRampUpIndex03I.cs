using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(773)]
    [Attributes(9)]
    public sealed class DcsTxBurstRampUpIndex03
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}