using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3062)]
    [Attributes(9)]
    public sealed class Gsm1900PowerLevels
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}