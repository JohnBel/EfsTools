using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3399)]
    [Attributes(9)]
    public sealed class Gsm1900PrechargeDur
    {
        public ushort Value { get; set; }
    }
}