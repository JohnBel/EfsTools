using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6232)]
    [Attributes(9)]
    public sealed class Bc13SubclassMask
    {
        public uint Value { get; set; }
    }
}