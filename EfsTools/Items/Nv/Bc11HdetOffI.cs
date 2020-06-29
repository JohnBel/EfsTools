using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3870)]
    [Attributes(9)]
    public sealed class Bc11HdetOff
    {
        public byte Value { get; set; }
    }
}