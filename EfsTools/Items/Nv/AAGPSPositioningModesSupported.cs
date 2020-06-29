using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1920)]
    [Attributes(9)]
    public sealed class AGpsPositioningModesSupported
    {
        public uint Value { get; set; }
    }
}