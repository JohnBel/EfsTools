using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5427)]
    [Attributes(9)]
    public sealed class Gsm1900PmeasG0F3
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}