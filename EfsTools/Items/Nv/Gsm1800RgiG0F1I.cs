using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5307)]
    [Attributes(9)]
    public sealed class Gsm1800RgiG0F1
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}