using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5751)]
    [Attributes(9)]
    public sealed class Bc13HdetOffV2
    {
        public ushort Value { get; set; }
    }
}