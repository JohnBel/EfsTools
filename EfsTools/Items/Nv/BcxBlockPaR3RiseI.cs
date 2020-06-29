using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4565)]
    [Attributes(9)]
    public sealed class BcxBlockPaR3Rise
    {
        public byte Value { get; set; }
    }
}