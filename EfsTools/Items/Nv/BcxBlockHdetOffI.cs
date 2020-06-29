using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4567)]
    [Attributes(9)]
    public sealed class BcxBlockHdetOff
    {
        public byte Value { get; set; }
    }
}