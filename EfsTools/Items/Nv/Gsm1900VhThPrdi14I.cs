using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2495)]
    [Attributes(9)]
    public sealed class Gsm1900VhThPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}