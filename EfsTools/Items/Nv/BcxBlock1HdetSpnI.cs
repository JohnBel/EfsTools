using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6073)]
    [Attributes(9)]
    public sealed class BcxBlock1HdetSpn
    {
        public byte Value { get; set; }
    }
}