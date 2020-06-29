using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6207)]
    [Attributes(9)]
    public sealed class BcxBlock1HdetSpnV2
    {
        public ushort Value { get; set; }
    }
}