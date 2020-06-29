using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1085)]
    [Attributes(9)]
    public sealed class Gsm1900TxBurstRampDownIndex07
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}