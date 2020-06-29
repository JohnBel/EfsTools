using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2145)]
    [Attributes(9)]
    public sealed class Gsm1900Prui10
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}