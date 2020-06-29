using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5743)]
    [Attributes(9)]
    public sealed class Bc5HdetOffV2
    {
        public ushort Value { get; set; }
    }
}