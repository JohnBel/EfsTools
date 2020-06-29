using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5423)]
    [Attributes(9)]
    public sealed class Gsm1800PmeasG0F3
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}