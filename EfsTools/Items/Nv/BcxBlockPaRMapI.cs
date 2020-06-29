using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6162)]
    [Attributes(9)]
    public sealed class BcxBlockPaRMap
    {
        public byte Value { get; set; }
    }
}