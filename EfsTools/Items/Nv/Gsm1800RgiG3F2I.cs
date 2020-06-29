using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5314)]
    [Attributes(9)]
    public sealed class Gsm1800RgiG3F2
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}