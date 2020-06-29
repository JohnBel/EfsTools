using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3900)]
    [Attributes(9)]
    public sealed class C0Bc11ImLevel2
    {
        public byte Value { get; set; }
    }
}