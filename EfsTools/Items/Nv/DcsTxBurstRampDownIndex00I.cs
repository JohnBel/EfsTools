using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(786)]
    [Attributes(9)]
    public sealed class DcsTxBurstRampDownIndex00
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}