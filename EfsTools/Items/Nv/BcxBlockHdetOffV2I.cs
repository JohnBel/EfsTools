using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6170)]
    [Attributes(9)]
    public sealed class BcxBlockHdetOffV2
    {
        public ushort Value { get; set; }
    }
}