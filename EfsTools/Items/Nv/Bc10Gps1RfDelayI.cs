using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5167)]
    [Attributes(9)]
    public sealed class Bc10Gps1RfDelay
    {
        public ushort Value { get; set; }
    }
}