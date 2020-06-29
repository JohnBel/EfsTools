using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7089)]
    [Attributes(9)]
    public sealed class C1Wcdma1500Im2QValue
    {
        public byte Value { get; set; }
    }
}