using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2777)]
    [Attributes(9)]
    public sealed class Gsm1900OpllBwVal
    {
        public byte Value { get; set; }
    }
}