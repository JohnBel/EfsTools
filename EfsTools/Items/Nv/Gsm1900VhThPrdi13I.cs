using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2496)]
    [Attributes(9)]
    public sealed class Gsm1900VhThPrdi13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}