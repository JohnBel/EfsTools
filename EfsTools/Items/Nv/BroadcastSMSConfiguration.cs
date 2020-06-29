using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(374)]
    [Attributes(9)]
    public sealed class BroadcastSmsConfiguration
    {
        public byte Value { get; set; }
    }
}