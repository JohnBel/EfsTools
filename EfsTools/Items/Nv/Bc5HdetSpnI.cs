using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1408)]
    [Attributes(9)]
    public sealed class Bc5HdetSpn
    {
        public byte Value { get; set; }
    }
}