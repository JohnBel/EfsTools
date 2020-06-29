using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5741)]
    [Attributes(9)]
    public sealed class Bc3HdetOffV2
    {
        public ushort Value { get; set; }
    }
}