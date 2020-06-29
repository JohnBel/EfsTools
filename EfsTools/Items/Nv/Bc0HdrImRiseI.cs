using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1880)]
    [Attributes(9)]
    public sealed class Bc0HdrImRise
    {
        public sbyte Value { get; set; }
    }
}