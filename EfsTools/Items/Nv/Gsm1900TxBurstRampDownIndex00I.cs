using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1078)]
    [Attributes(9)]
    public sealed class Gsm1900TxBurstRampDownIndex00
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}