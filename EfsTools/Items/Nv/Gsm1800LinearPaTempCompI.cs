using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5397)]
    [Attributes(9)]
    public sealed class Gsm1800LinearPaTempComp
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}