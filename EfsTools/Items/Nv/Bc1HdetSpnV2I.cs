using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5755)]
    [Attributes(9)]
    public sealed class Bc1HdetSpnV2
    {
        public ushort Value { get; set; }
    }
}