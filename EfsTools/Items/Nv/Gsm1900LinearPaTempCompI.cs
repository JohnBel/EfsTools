using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5398)]
    [Attributes(9)]
    public sealed class Gsm1900LinearPaTempComp
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}