using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5390)]
    [Attributes(9)]
    public sealed class Gsm1800EdgePaLoToMid
    {
        public ushort Value { get; set; }
    }
}