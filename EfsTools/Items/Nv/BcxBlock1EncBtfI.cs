using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6075)]
    [Attributes(9)]
    public sealed class BcxBlock1EncBtf
    {
        public uint Value { get; set; }
    }
}