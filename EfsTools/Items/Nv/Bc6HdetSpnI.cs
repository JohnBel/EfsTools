using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1219)]
    [Attributes(9)]
    public sealed class Bc6HdetSpn
    {
        public byte Value { get; set; }
    }
}