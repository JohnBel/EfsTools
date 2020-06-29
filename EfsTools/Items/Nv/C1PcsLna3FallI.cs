using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1047)]
    [Attributes(9)]
    public sealed class C1PcsLna3Fall
    {
        public sbyte Value { get; set; }
    }
}