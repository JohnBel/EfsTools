using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1389)]
    [Attributes(9)]
    public sealed class Bc5Gps1RfDelay
    {
        public short Value { get; set; }
    }
}