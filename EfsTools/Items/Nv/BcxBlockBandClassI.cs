using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6208)]
    [Attributes(9)]
    public sealed class BcxBlockBandClass
    {
        public byte Value { get; set; }
    }
}