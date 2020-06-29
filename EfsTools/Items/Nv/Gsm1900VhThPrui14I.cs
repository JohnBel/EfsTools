using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2492)]
    [Attributes(9)]
    public sealed class Gsm1900VhThPrui14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}