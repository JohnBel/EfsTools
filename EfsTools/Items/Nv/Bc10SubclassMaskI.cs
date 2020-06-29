using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6229)]
    [Attributes(9)]
    public sealed class Bc10SubclassMask
    {
        public uint Value { get; set; }
    }
}