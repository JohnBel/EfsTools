using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4883)]
    [Attributes(9)]
    public sealed class Bc4PaRMap
    {
        public byte Value { get; set; }
    }
}