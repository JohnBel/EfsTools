using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5321)]
    [Attributes(9)]
    public sealed class Gsm1900RgiG2F2
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}