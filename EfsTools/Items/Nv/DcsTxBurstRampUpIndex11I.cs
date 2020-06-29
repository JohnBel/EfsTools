using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(781)]
    [Attributes(9)]
    public sealed class DcsTxBurstRampUpIndex11
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}