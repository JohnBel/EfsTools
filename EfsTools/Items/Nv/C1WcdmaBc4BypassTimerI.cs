using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4517)]
    [Attributes(9)]
    public sealed class C1WcdmaBc4BypassTimer
    {
        public ushort Value { get; set; }
    }
}