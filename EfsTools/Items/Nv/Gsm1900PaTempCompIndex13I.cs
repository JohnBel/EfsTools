using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1339)]
    [Attributes(9)]
    public sealed class Gsm1900PaTempCompIndex13
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}