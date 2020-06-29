using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1334)]
    [Attributes(9)]
    public sealed class Gsm1900PaTempCompIndex08
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}