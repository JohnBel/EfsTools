using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4886)]
    [Attributes(9)]
    public sealed class Bc11PaRMap
    {
        public byte Value { get; set; }
    }
}