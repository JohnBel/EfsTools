using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1092)]
    [Attributes(9)]
    public sealed class Gsm1900TxBurstRampDownIndex14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}