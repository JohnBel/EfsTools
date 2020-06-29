using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2839)]
    [Attributes(9)]
    public sealed class BtActive
    {
        public byte Value { get; set; }
    }
}