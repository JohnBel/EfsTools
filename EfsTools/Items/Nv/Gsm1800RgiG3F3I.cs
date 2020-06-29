using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5410)]
    [Attributes(9)]
    public sealed class Gsm1800RgiG3F3
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}