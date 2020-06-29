using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5758)]
    [Attributes(9)]
    public sealed class Bc4HdetSpnV2
    {
        public ushort Value { get; set; }
    }
}