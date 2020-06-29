using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2753)]
    [Attributes(9)]
    public sealed class Gsm1900CalpathRsb
    {
        [FieldCount(4)]
        public ushort[] Value { get; set; }
    }
}