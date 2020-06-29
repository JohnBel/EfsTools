using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4182)]
    [Attributes(9)]
    public sealed class Gsm1900TxRsbCorr
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}