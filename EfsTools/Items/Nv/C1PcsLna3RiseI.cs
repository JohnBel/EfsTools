using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1039)]
    [Attributes(9)]
    public sealed class C1PcsLna3Rise
    {
        public sbyte Value { get; set; }
    }
}