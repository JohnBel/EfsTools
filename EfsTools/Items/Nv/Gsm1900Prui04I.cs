using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2139)]
    [Attributes(9)]
    public sealed class Gsm1900Prui04
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}