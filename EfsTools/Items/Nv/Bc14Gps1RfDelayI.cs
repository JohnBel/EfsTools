using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3540)]
    [Attributes(9)]
    public sealed class Bc14Gps1RfDelay
    {
        public ushort Value { get; set; }
    }
}