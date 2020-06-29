using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1890)]
    [Attributes(9)]
    public sealed class Bc0HdrImLevel
    {
        public sbyte Value { get; set; }
    }
}