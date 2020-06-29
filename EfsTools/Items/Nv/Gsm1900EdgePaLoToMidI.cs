using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5392)]
    [Attributes(9)]
    public sealed class Gsm1900EdgePaLoToMid
    {
        public ushort Value { get; set; }
    }
}