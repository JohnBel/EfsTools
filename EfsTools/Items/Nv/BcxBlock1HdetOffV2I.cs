using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6206)]
    [Attributes(9)]
    public sealed class BcxBlock1HdetOffV2
    {
        public ushort Value { get; set; }
    }
}