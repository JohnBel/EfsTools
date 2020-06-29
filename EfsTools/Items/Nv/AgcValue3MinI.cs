using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(587)]
    [Attributes(9)]
    public sealed class AgcValue3Min
    {
        public sbyte Value { get; set; }
    }
}