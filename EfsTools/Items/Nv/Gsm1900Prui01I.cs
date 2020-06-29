using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2136)]
    [Attributes(9)]
    public sealed class Gsm1900Prui01
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}