using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6198)]
    [Attributes(9)]
    public sealed class BcxBlock1PaRMap
    {
        public byte Value { get; set; }
    }
}