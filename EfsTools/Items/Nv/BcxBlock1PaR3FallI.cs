using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6071)]
    [Attributes(9)]
    public sealed class BcxBlock1PaR3Fall
    {
        public byte Value { get; set; }
    }
}