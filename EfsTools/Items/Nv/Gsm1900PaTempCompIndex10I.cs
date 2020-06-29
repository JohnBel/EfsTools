using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1336)]
    [Attributes(9)]
    public sealed class Gsm1900PaTempCompIndex10
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}