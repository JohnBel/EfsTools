using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(380)]
    [Attributes(9)]
    public sealed class BypassTimer
    {
        public byte Value { get; set; }
    }
}