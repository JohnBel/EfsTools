using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(972)]
    [Attributes(9)]
    public sealed class C0GrpDelayAdj
    {
        public byte Value { get; set; }
    }
}