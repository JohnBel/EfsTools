using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(70)]
    [Attributes(9)]
    public sealed class CallFadeAlert
    {
        public byte Value { get; set; }
    }
}