using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(770)]
    [Attributes(9)]
    public sealed class DcsTxBurstRampUpIndex00
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}