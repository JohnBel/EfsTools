using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1089)]
    [Attributes(9)]
    public sealed class Gsm1900TxBurstRampDownIndex11
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}