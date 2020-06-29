using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1330)]
    [Attributes(9)]
    public sealed class Gsm1900PaTempCompIndex04
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}