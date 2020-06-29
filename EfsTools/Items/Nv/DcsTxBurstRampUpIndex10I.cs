using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(780)]
    [Attributes(9)]
    public sealed class DcsTxBurstRampUpIndex10
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}