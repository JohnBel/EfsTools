using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1069)]
    [Attributes(9)]
    public sealed class Gsm1900TxBurstRampUpIndex07
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}