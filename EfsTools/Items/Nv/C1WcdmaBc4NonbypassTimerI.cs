using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4516)]
    [Attributes(9)]
    public sealed class C1WcdmaBc4NonbypassTimer
    {
        public byte Value { get; set; }
    }
}