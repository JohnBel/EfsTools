using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1091)]
    [Attributes(9)]
    public sealed class Gsm1900TxBurstRampDownIndex13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}