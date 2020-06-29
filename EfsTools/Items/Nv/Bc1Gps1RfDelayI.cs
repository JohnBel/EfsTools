using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1624)]
    [Attributes(9)]
    public sealed class Bc1Gps1RfDelay
    {
        public short Value { get; set; }
    }
}