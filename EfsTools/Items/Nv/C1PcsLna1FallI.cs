using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1045)]
    [Attributes(9)]
    public sealed class C1PcsLna1Fall
    {
        public sbyte Value { get; set; }
    }
}