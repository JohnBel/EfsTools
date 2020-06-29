using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5766)]
    [Attributes(9)]
    public sealed class Bc12HdetSpnV2
    {
        public ushort Value { get; set; }
    }
}