using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(200)]
    [Attributes(9)]
    public sealed class CdmaAdjFactor
    {
        public byte Value { get; set; }
    }
}