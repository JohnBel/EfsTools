using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(779)]
    [Attributes(9)]
    public sealed class DcsTxBurstRampUpIndex09
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}