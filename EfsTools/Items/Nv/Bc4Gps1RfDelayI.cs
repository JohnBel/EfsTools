using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1467)]
    [Attributes(9)]
    public sealed class Bc4Gps1RfDelay
    {
        public short Value { get; set; }
    }
}