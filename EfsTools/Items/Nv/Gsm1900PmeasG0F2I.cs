using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5351)]
    [Attributes(9)]
    public sealed class Gsm1900PmeasG0F2
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}