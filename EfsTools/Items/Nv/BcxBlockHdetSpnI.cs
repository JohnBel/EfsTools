using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4568)]
    [Attributes(9)]
    public sealed class BcxBlockHdetSpn
    {
        public byte Value { get; set; }
    }
}