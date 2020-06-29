using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1033)]
    [Attributes(9)]
    public sealed class C1CdmaLna1Rise
    {
        public sbyte Value { get; set; }
    }
}