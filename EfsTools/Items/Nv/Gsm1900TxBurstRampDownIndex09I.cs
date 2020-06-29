using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1087)]
    [Attributes(9)]
    public sealed class Gsm1900TxBurstRampDownIndex09
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}