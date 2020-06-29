using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(385)]
    [Attributes(9)]
    public sealed class AgcPhaseOffset
    {
        public byte Value { get; set; }
    }
}