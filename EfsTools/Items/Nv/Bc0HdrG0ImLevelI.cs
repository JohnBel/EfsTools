using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3388)]
    [Attributes(9)]
    public sealed class Bc0HdrG0ImLevel
    {
        public sbyte Value { get; set; }
    }
}