using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5430)]
    [Attributes(9)]
    public sealed class Gsm1900PmeasG3F3
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}