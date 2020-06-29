using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3871)]
    [Attributes(9)]
    public sealed class Bc11HdetSpn
    {
        public byte Value { get; set; }
    }
}