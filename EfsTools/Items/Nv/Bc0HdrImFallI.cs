using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1879)]
    [Attributes(9)]
    public sealed class Bc0HdrImFall
    {
        public sbyte Value { get; set; }
    }
}