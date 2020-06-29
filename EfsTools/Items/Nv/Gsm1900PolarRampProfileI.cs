using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3510)]
    [Attributes(9)]
    public sealed class Gsm1900PolarRampProfile
    {
        [FieldCount(60)]
        public ushort[] Value { get; set; }
    }
}