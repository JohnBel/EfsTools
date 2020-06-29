using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4884)]
    [Attributes(9)]
    public sealed class Bc5PaRMap
    {
        public byte Value { get; set; }
    }
}