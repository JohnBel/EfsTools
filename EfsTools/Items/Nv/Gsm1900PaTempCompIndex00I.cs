using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1326)]
    [Attributes(9)]
    public sealed class Gsm1900PaTempCompIndex00
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}