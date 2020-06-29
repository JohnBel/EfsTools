using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1006)]
    [Attributes(9)]
    public sealed class C1PcsDaccQaccum2
    {
        public byte Value { get; set; }
    }
}