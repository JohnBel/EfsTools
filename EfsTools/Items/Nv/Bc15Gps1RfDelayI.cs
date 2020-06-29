using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4272)]
    [Attributes(9)]
    public sealed class Bc15Gps1RfDelay
    {
        public ushort Value { get; set; }
    }
}