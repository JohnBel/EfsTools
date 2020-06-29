using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3789)]
    [Attributes(9)]
    public sealed class C1Wcdma1900VgaGainOffset
    {
        public short Value { get; set; }
    }
}