using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(771)]
    [Attributes(9)]
    public sealed class DcsTxBurstRampUpIndex01
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}