using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4609)]
    [Attributes(9)]
    public sealed class C1BcxBlockLna4Offset
    {
        public short Value { get; set; }
    }
}