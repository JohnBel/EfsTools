using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [Subscription]
    [EfsFile("/policyman/call_mode", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CallMode

    {
        public byte Value { get; set; }
    }
}