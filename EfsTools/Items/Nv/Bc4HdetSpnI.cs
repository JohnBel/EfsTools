using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1486)]
    [Attributes(9)]
    public sealed class Bc4HdetSpn
    {
        public byte Value { get; set; }
    }
}