using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1054)]
    [Attributes(9)]
    public sealed class C1PcsImLevel2
    {
        public byte Value { get; set; }
    }
}