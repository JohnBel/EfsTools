using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1080)]
    [Attributes(9)]
    public sealed class Gsm1900TxBurstRampDownIndex02
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}