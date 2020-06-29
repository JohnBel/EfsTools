using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1229)]
    [Attributes(9)]
    public sealed class Bc6LnaRange12Offset
    {
        public short Value { get; set; }
    }
}