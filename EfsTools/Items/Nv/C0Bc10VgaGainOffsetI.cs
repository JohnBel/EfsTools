using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5220)]
    [Attributes(9)]
    public sealed class C0Bc10VgaGainOffset
    {
        public short Value { get; set; }
    }
}