using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5311)]
    [Attributes(9)]
    public sealed class Gsm1800RgiG0F2
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}